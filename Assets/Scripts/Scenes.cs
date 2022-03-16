using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Scenes : MonoBehaviour
{
    public void Load(string Scene)
    {
        if(Scene == "Q")
        {
            Application.Quit();
        }
        SceneManager.LoadScene(Scene);

    }

}
