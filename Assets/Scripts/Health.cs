using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Health : MonoBehaviour
{
    int health = 10;
    public TextMeshProUGUI text;

    void Update()
    {
        text.text = "Health: " + health;
        if(health <= 0)
        {
            SceneManager.LoadScene("Lose");
        }
    }

    public void healthDown()
    {
        health -= 1;
    }
}
