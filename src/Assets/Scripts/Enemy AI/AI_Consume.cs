using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Consume : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Food"))
        {
            Destroy(other.gameObject);
        }
    }

}
