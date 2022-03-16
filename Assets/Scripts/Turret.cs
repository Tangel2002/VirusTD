using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public Transform target;
    float check = 0;
    public float range = 5;
    public Transform gun;
    public float shootCoodlown = 1.5f;
    public float shootRate = 1;
    public GameObject bulletPrefab;
    public Transform firePoint;
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

        Vector2 Direction = target.position - transform.position;
        float angle = Mathf.Atan2(Direction.y, Direction.x) * Mathf.Rad2Deg;
        Quaternion lookRot = Quaternion.AngleAxis(angle, Vector3.forward);
        gun.rotation = Quaternion.Slerp(transform.rotation, lookRot, 20f *Time.deltaTime);

        if(shootCoodlown <= 0f)
        {
            Shoot();
            shootCoodlown = 1f / shootRate;
        }
        shootCoodlown -= Time.deltaTime;
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
        GameObject laserClone = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Laser las = laserClone.GetComponent<Laser>();

        if(las != null)
        {
            las.Attack(target);
        }
    }
}
