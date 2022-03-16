using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pathing : MonoBehaviour
{

    public GameObject TrackPoints;
    Transform[] waypoints;
    Health endOfPath;
    Spawning killCount;

    private void Start()
    {
        waypoints = TrackPoints.GetComponentsInChildren<Transform>();
        endOfPath = GameObject.FindGameObjectWithTag("HealthMG").GetComponent<Health>();
        killCount = GameObject.FindGameObjectWithTag("Respawn").GetComponent<Spawning>();
    }
    

    public float movespeed = 2f;
    int index = 1;

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
        if(index == 77)
        {
            endOfPath.healthDown();
            killCount.killed++;
            Destroy(this.gameObject);

        }
    }
}
