using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Construct : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject towerDecal;
    public GameObject tower;
    GameObject clone;

    bool placed = true;
    // Update is called once per frame
    void Update()
    {
        if (placed == false)
        {
            clone.transform.position = Input.mousePosition;
        }
    }


    public void Place()
    {
        placed = false;
        clone = Instantiate(towerDecal, Input.mousePosition, Quaternion.identity);

    }

    public void Placed()
    {
        placed=true;
        Instantiate(tower, Input.mousePosition, Quaternion.identity);
    }
}
