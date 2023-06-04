using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableScript : MonoBehaviour
{
    public GameObject scriptHolder;

    public void enableScript()
    {
        scriptHolder.GetComponent<Spawner>().enabled = true;
    }
}
