using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pathing : MonoBehaviour
{

    public GameObject TrackPoints;
    Transform[] waypoints;
    private void Start()
    {
        waypoints = TrackPoints.GetComponentsInChildren<Transform>();
    }
    

    public float movespeed = 2f;
    int index = 1;

    // Update is called once per frame
    void Update()
    {
        print(index);
        
        if(index <= waypoints.Length - 1)
        {
            this.transform.position = Vector2.MoveTowards(transform.position, waypoints[index].position, movespeed * Time.deltaTime);
            print(waypoints[index].name);
            if(this.transform.position == waypoints[index].position)
            {
                index++;
            }
        }
    }
}
