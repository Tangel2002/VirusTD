using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Construct : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject laserDecal;
    public GameObject laser;
    public GameObject sniperDecal;
    public GameObject sniper;
    public Eco BobuxManage;
    public int cost = 1;
    GameObject clone;
    public PolygonCollider2D track;
    int towerType = -1;
    bool obstructed = false;
    bool placed = true;
    // Update is called once per frame
    void Update()
    {
        Vector3 adjustedPos = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        if (placed == false)
        {
            if (clone != null)
            {
                clone.transform.position = adjustedPos;
            }
        }
        if (Input.GetMouseButtonDown(0) && placed == false)
        {
            if (clone.GetComponent<CircleCollider2D>().IsTouching(track))
            {
                obstructed = true;
            }
            else
                obstructed = false;
            if(obstructed == false)
            {
                if(BobuxManage.Verify(cost) == true)
                {
                    Placed(adjustedPos);
                    BobuxManage.RemoveBobux(cost);
                }
                
            }
        }
        if(Input.GetMouseButtonDown(1))
        {
            Destroy(clone);
        }
    }



    public void Place(string type)
    {
        placed = false;
        
        if(type == "Laser")
        {
            clone = (GameObject)Instantiate(laserDecal, Input.mousePosition, Quaternion.identity);
            towerType = 1;
            cost = 1;
        }
        if(type == "Sniper")
        {
            clone = (GameObject)Instantiate(sniperDecal, Input.mousePosition, Quaternion.identity);
            towerType = 2;
            cost = 2;
        }
    }

    public void Placed(Vector3 pos)
    {
        Destroy(clone);
        placed=true;
        if(towerType == 1)
        {
            Instantiate(laser, pos, Quaternion.identity);
        }
        if (towerType == 2)
        {
            Instantiate(sniper, pos, Quaternion.identity);
        }
        towerType = -1;
    }
}
