using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ActivateHotkeys : MonoBehaviour
{
    public PauseManager pauseManager;

    public GameObject Exit;

    void Start()
    {
        pauseManager = GetComponent<PauseManager>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseManager.Pause();
            Exit.SetActive(true);
        }
    }
}
