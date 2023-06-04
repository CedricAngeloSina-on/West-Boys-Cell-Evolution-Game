using UnityEngine;
using UnityEngine.Events;

public class RandomFactInvoker : MonoBehaviour
{
    public UnityEvent randomFactInvoke = new UnityEvent();
    public TimerScript timer;

    public float randomTime;
    public float randomRange;
    // public float currentTime;
    public bool hasPopup = false;
    
    [Header("Range Settings")]
    public float randomRangeA;
    public float randomRangeB;
 
    void Start()
    {
        randomRange = Random.Range(randomRangeA, randomRangeB);

        randomTime = timer.currentTime + randomRange;
    }

    void Update()
    {
        // currentTime = timer.currentTime;
        if (timer.currentTime > randomTime && !hasPopup)
        {
            randomFactInvoke.Invoke();
            hasPopup = true;
        }
    }
}
