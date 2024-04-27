using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P3_Distance : MonoBehaviour
{
    GameObject personaje;
    GameObject enemigo;
    GameObject enemigo1;
    GameObject enemigo2;

    // Start is called before the first frame update
    void Start()
    {
        personaje = GameObject.Find("Toon Chick");
        enemigo = GameObject.Find("Enemigo");
        enemigo1 = GameObject.Find("Enemigo1");
        enemigo2 = GameObject.Find("Enemigo2");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Enemigo 1: " +getDistance());
        Debug.Log("Enemigo 2: " +getDistance1());
        Debug.Log("Enemigo 3: " + getDistance2());
    }

    public float getDistance(){
        float distance = Vector3.Distance(personaje.transform.position,
        enemigo.transform.position);
        return distance;        
    }
    public float getDistance1()
    {
        float distance = Vector3.Distance(personaje.transform.position,
        enemigo1.transform.position);
        return distance;
    }

    public float getDistance2()
    {
        float distance = Vector3.Distance(personaje.transform.position,
        enemigo2.transform.position);
        return distance;
    }
}
