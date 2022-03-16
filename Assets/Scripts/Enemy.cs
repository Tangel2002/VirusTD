using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    GameObject Eco;
    public int Health = 1;

    void Start()
    {
        Eco = GameObject.FindGameObjectWithTag("Eco");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
