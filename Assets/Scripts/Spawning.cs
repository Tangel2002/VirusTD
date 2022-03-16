using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{

    public GameObject spawning;

    public GameObject spawningPrefabTrojan;
    public GameObject spawningPrefabMEMZ;
    bool roundStarted = false;
    bool allSpawned = false;
    int spawningCount = 5;
    float timer;
    float spawnDelay;
    int killed = 0;
    int index = 1;
    // Update is called once per frame
    void Update()
    {
        if (roundStarted == false)
        {
            timer += Time.deltaTime;
        }

        if(timer >= 5)
        {
            roundStarted = true;
            timer = 0;
        }
        if(roundStarted == true)
        {
            spawnDelay += Time.deltaTime;
            if(spawnDelay >= 1.2)
            {
                if (allSpawned == false)
                {
                    RoundStart();
                    if (index != spawningCount)
                    {
                        index++;
                    }
                    else if (index == spawningCount) 
                    {
                        index = 0;
                        allSpawned = true;
                    }
                }
            }
        }
        if(killed == spawningCount)
        {
            roundStarted = false;
        }
    }

    void RoundStart()
    {
        int chooser = Random.Range(1, 3);

        if (chooser == 1)
        {
            Instantiate(spawningPrefabMEMZ, spawning.transform);
        }
        if (chooser == 2)
        {
            Instantiate(spawningPrefabTrojan, spawning.transform);
        }
        spawnDelay = 0;
    }
}
