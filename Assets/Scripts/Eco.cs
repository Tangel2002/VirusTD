using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Eco : MonoBehaviour
{
    private float Bobux = 5;
    public TextMeshProUGUI text;


    private void Update()
    {
        text.text = "Bobux: " + Bobux;
    }
    public bool Verify(int cost)
    {
        if (Bobux < cost)
        {
            return false;
        }
        else
            return true;
    }

    public void AddBobux(float depo)
    {
        Bobux += depo;
    }

    public void RemoveBobux(int withdraw)
    {
        Bobux -= withdraw;
    }
}
