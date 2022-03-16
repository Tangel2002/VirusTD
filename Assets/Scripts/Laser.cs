using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{

    Transform target;

    public void Attack(Transform enemy)
    {
        target = enemy;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
