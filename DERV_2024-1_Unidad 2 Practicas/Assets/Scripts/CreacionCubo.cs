using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creacion : MonoBehaviour
{
    [SerializeField]
    GameObject objeto;
    [SerializeField]
    GameObject ubicacion;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)){
            GameObject obj = Instantiate(objeto, ubicacion.transform.position, ubicacion.transform.rotation);
            Destroy(obj, 5);
        }
    }
}
