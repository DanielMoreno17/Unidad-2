using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Colision2 : MonoBehaviour
{
    [SerializeField] ManagerSpawn manager;
    [SerializeField] List<GameObject> spawnList;
    [SerializeField] GameObject objetoEnemigo;

    int index = 0;


    void Start()
    {
        
    }
  
    private void OnCollisionEnter(Collision collision)
    { 
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            index = Random.Range(0, spawnList.Count);
            GameObject obj = Instantiate(objetoEnemigo, spawnList[index].transform.position,
            spawnList[index].transform.rotation);
            index = 0;
        }
        manager.createEnemy();


    }
}
