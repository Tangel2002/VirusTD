using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Eco : MonoBehaviour
{
    private float Bobux = 99;
    public TextMeshProUGUI text;


    private void Update()
    {
        text.text = "Bobux: " + Bobux;

        if(Bobux >= 100)
        {
            SceneManager.LoadScene("Win");
        }
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
