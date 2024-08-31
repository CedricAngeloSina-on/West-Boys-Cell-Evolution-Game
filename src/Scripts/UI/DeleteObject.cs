using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteObject : MonoBehaviour
{
    public GameObject Target;

    public void DestroyObject()
    {
        Destroy(Target);
    }
}
