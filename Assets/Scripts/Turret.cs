using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    Transform target;
    float check = 0;
    public float range = 5;
    public Transform gun;

    // Update is called once per frame
    void Update()
    {
        if(check < 0.5)
        {
            check += Time.deltaTime;
        }
        else
            findNearestEnemy();

        if(target == null)
        {
            return;
        }

        Vector3 Direction = target.position - transform.position;
        Quaternion lookRot = Quaternion.LookRotation(Direction);
        Vector3 rotation = lookRot.eulerAngles;
        gun.rotation = Quaternion.Euler(0f, 0f, rotation.z);


    }

    void findNearestEnemy()
    {
        check = 0;
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        float shortestDistance = Mathf.Infinity;
        GameObject closestEnemy = null;
        foreach(GameObject enemy in enemies)
        {
            float distance = Vector2.Distance(transform.position, enemy.transform.position);
            if(distance < shortestDistance)
            {
                shortestDistance = distance;
                closestEnemy = enemy;
            }

        }

        if(closestEnemy != null && shortestDistance <= range)
        {
            target = closestEnemy.transform;
        }
        else
            target = null;

    }

    void Shoot()
    {

    }
}
