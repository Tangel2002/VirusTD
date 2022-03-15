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
            Vector2 adjustedPos = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
            clone.transform.position = adjustedPos;
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