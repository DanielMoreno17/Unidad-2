using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerSpawn : MonoBehaviour
{
    [SerializeField] List<GameObject> spawnList;
    [SerializeField] GameObject objetoEnemigo;
    int index = 0;  
    // Start is called before the first frame update
    void Start()
    {
        createEnemy();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void createEnemy()
    {
        index = Random.Range(0, spawnList.Count);
        GameObject obj = Instantiate(objetoEnemigo, spawnList[index].transform.position,
            spawnList[index].transform.rotation);

        Destroy(obj, 0.5f);
    }
}
