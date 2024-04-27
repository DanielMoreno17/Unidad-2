using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTransform : MonoBehaviour
{



    [SerializeField] private float velociadad = 7;
   
    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(transform.forward * velociadad * Time.deltaTime);
        }else if(Input.GetKey(KeyCode.S)) {
            transform.Translate(transform.forward * -1 * velociadad * Time.deltaTime);
        } else if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(transform.right * velociadad * Time.deltaTime);
        } else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(transform.right * -1 * velociadad * Time.deltaTime);
        }
    }
}
