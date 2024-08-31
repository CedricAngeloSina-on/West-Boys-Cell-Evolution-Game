using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateDebug : MonoBehaviour
{
    public GameObject Debug;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.BackQuote))
        {
            if (Debug.activeInHierarchy)
            {
                Debug.SetActive(false);
            }
            else
            {
                Debug.SetActive(true);
            }
        }

    }
}
