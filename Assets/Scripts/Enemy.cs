using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    GameObject Eco;
    public int Health = 1;
    GameObject Spawner;
    Spawning reference;
    Eco addMoney;
    void Start()
    {
        Spawner = GameObject.FindGameObjectWithTag("Respawn");
        Eco = GameObject.FindGameObjectWithTag("Eco");
        addMoney = Eco.GetComponent<Eco>();
        reference = Spawner.GetComponent<Spawning>();
    }
    // Update is called once per frame
    void Update()
    {
        if(Health <= 0)
        {
            Destroy(gameObject);
            addMoney.AddBobux(0.25f);
            reference.killed++;
            return;
        }
    }
}
