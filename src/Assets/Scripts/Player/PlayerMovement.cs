using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public PlayerStats stats;
    public bool isMoving;
    public bool isReading;

    void Update()
    {
        FaceTowards();

        if (Input.GetMouseButton(0))
        {
            isMoving = true;
        } else
        {
            isMoving = false;
        }

        if (isMoving && !isReading)
        {
            MouseMove();
        }
            
    }

    void MouseMove()
    {
        Vector2 Target = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        transform.position = Vector2.MoveTowards(transform.position, Target, stats.Speed * Time.deltaTime);
    }

    void FaceTowards()
    {
        Vector2 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2 (mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);
        transform.up = direction;        
    }
}
