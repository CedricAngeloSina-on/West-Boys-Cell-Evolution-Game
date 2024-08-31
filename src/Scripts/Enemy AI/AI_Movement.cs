using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Movement : MonoBehaviour
{
    public float speed = 3;
    public float range = .5f;
    public float maxDistance = 30;

    
    public GameObject Player;
    public float distanceBetween = 5;
    private float distance;

    Vector2 wayPoint;

    void Start()
    {
        SetDestination();
    }

    void Update()
    {
        Player = GameObject.FindWithTag("Player");
        distance = Vector2.Distance(transform.position, Player.transform.position);
        Vector2 directionP = Player.transform.position - transform.position;
        directionP.Normalize();
        float angle = Mathf.Atan2(directionP.y, directionP.x) * Mathf.Rad2Deg;

        if (distance < distanceBetween)
        {
            transform.up = Player.transform.position - transform.position;
            transform.position = Vector2.MoveTowards(this.transform.position, Player.transform.position, speed * Time.deltaTime);
            // transform.rotation = Quaternion.Euler(Vector3.forward * angle);
        } else {
            Wander();
        }
    }

    void Wander()
    {
        transform.position = Vector2.MoveTowards(transform.position, wayPoint, speed * Time.deltaTime);
        transform.up = wayPoint - (Vector2)transform.position;
        if (Vector2.Distance(transform.position, wayPoint) < range)
        {
            SetDestination();
        }
    }
    
    void SetDestination()
    {
        wayPoint = new Vector2(Random.Range(-maxDistance, maxDistance), Random.Range(-maxDistance, maxDistance));
    }
}