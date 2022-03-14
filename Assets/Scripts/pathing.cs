using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pathing : MonoBehaviour
{


    public Transform[] waypoints;

    public float movespeed = 2f;
    int index = 0;

    // Update is called once per frame
    void Update()
    {
        if(index <= waypoints.Length - 1)
        {
            this.transform.position = Vector2.MoveTowards(transform.position, waypoints[index].position, movespeed * Time.deltaTime);

            if(this.transform.position == waypoints[index].position)
            {
                index++;
            }
        }
    }
}
