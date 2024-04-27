using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respwann : MonoBehaviour
{

    [SerializeField]
    GameObject spawnpoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float y =transform.position.y;
        if (y < -5f)
        {
            transform.position = spawnpoint.transform.position;
        }
        
    }
}
