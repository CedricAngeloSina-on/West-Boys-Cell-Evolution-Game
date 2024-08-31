using UnityEngine;
using UnityEngine.Events;

public class TutConditionInvoker : MonoBehaviour
{
    public UnityEvent reachLevel2 = new UnityEvent();
    public UnityEvent reachLevel10 = new UnityEvent();
    public UnityEvent gotDamaged = new UnityEvent();

    public PlayerLevel level;
    public PlayerHealth hp;

    public bool hasReachedLevel2 = false;
    public bool hasReachedLevel9 = false;
    public bool firstTimeReceivingDamage = false;

    void Update()
    {
        if (hasReachedLevel2 == false && level.level == 2)
        {
            reachLevel2.Invoke();
            hasReachedLevel2 = true;
        }
        if (hasReachedLevel9 == false && level.level == 9)
        {
            reachLevel10.Invoke();
            hasReachedLevel9 = true;
        }
        if (hp.hasTakenDamage && !firstTimeReceivingDamage)
        {
            gotDamaged.Invoke();
            firstTimeReceivingDamage = true;
        }
    }
}
