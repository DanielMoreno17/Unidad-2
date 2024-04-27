using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P4_MoveTowardsV2 : MonoBehaviour
{
    GameObject personaje;
    GameObject enemigo;
    GameObject enemigo1;
    GameObject enemigo2;

    P3_Distance revDistance;


    // Start is called before the first frame update
    void Start()
    {
        personaje = GameObject.Find("Toon Chick");
        enemigo = GameObject.Find("Enemigo");
        enemigo1 = GameObject.Find("Enemigo1");
        enemigo2 = GameObject.Find("Enemigo2");
        revDistance = GetComponent<P3_Distance>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (revDistance.getDistance()<12.0f){
            enemigo.transform.position = Vector3.MoveTowards(
                enemigo.transform.position,
                personaje.transform.position,
                Time.deltaTime * 2f);
        }

        if (revDistance.getDistance1() < 12.0f)
        {
            enemigo1.transform.position = Vector3.MoveTowards(
                enemigo1.transform.position,
                personaje.transform.position,
                Time.deltaTime * 2f);
        }

        if (revDistance.getDistance2() < 12.0f)
        {
            enemigo2.transform.position = Vector3.MoveTowards(
                enemigo2.transform.position,
                personaje.transform.position,
                Time.deltaTime * 2f);
        }
    }
}
