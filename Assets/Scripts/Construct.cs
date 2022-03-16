using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Construct : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject towerDecal;
    public GameObject tower;
    public Eco BobuxManage;
    public int cost = 1;
    GameObject clone;
    public PolygonCollider2D track;

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



    public void Place()
    {
        placed = false;
        clone = (GameObject)Instantiate(towerDecal, Input.mousePosition, Quaternion.identity);

    }

    public void Placed(Vector3 pos)
    {
        Destroy(clone);
        placed=true;
        Instantiate(tower, pos, Quaternion.identity);
    }
}
