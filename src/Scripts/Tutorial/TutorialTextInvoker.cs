using UnityEngine;
using UnityEngine.Events;

public class TutorialTextInvoker : MonoBehaviour
{
    public UnityEvent onTriggerEnter = new UnityEvent();
    public UnityEvent onTriggerExit = new UnityEvent();
 
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) onTriggerEnter.Invoke();
    }
 
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player")) onTriggerExit.Invoke();
    }
}
