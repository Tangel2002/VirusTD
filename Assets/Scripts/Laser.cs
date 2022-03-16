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
        if(target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector2 Direction = target.position - transform.position;
        float distance = 50f * Time.deltaTime;

        if(Direction.magnitude <= distance)
        {
            Hit();
        }
        transform.Translate(Direction.normalized * distance, Space.World);
    }

    void Hit()
    {
        Enemy hurt = target.GetComponent<Enemy>();
        hurt.Health -= 1;
        Destroy(gameObject);
    }
}
