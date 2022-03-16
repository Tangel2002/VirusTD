using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    GameObject Eco;
    public int Health = 1;
    GameObject Spawner;
    Spawning reference;
    void Start()
    {
        Spawner = GameObject.FindGameObjectWithTag("Respawn");
        Eco = GameObject.FindGameObjectWithTag("Eco");
        reference = Spawner.GetComponent<Spawning>();
    }
    // Update is called once per frame
    void Update()
    {
        if(Health <= 0)
        {
            Destroy(gameObject);
            reference.killed++;
            return;
        }
    }
}
