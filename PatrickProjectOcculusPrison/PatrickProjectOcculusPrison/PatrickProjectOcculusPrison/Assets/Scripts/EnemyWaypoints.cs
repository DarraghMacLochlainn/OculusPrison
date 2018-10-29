using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWaypoints : MonoBehaviour
{
    private int nextWaypoint;

    public GameObject[] Waypoints;

    // Use this for initialization
    void Start()
    {
        nextWaypoint = 0;
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(Waypoints[nextWaypoint].transform
            .position);
        // new Vector3 (Waypoints[nextWaypoint].transform.position.x,Waypoints[nextWaypoint].transform.position.y,0f);
    }

    private void OnTriggerEnter()
    {
        if (transform.position == Waypoints[nextWaypoint].transform.position)
        {
            nextWaypoint++;
            if (nextWaypoint > Waypoints.Length)
            {
                nextWaypoint = 0;
            }
        }
    }
}