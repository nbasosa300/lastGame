using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{

    public GameObject GroundTile;
    Vector3 NextSpawn;
    // Start is called before the first frame update
   public  void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            if (i < 3)
            {
                SpawnTile(false);
            }
            else { 
           
            SpawnTile(true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }


   public  void SpawnTile(bool spawnItems)
    {
        GameObject temp = Instantiate(GroundTile, NextSpawn, Quaternion.identity);
        NextSpawn = temp.transform.GetChild(1).transform.position;




        if (spawnItems) {
            temp.GetComponent<GroundTile>().SpawnObstacle();
            temp.GetComponent<GroundTile>().SpawnCoins();
        }
    }
}
