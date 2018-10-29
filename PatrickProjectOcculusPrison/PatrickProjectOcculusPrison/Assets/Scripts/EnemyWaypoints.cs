using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWaypoints : MonoBehaviour
{
    private int nextWaypoint = 0;
    float speed = 5.0f;
    public GameObject[] Waypoints;
    private bool OnWaypoint = false;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        MoveEnemey();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (OnWaypoint == false)
        {
            print("Collision  " + nextWaypoint + "  " + Waypoints.Length);
            if (other.CompareTag("Waypoint"))
            {
                if (nextWaypoint >= Waypoints.Length-1)
                {
                    nextWaypoint = 0;
                }
                else
                {
                    nextWaypoint++;
                }

                OnWaypoint = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (OnWaypoint == true)
        {
            print("EXIT  " + nextWaypoint + "  " + Waypoints.Length);    
            OnWaypoint = false;
        }
    }

    private void MoveEnemey() {
        //if player not seen
        Vector3 target = new Vector3(Waypoints[nextWaypoint].transform.position.x, Waypoints[nextWaypoint].transform.position.y, Waypoints[nextWaypoint].transform.position.z);
        //else if player is seen
        //player = target
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
}