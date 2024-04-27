using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision1 : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioSource KillSonido;

    public Kills cuenta;
    public AudioClip KillSound;
    void Start()
    {
      cuenta = GetComponent<Kills>();  
        KillSonido = GetComponent<AudioSource>();
    }
    int contE = 0, contF = 0, contH;
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        string name = collision.gameObject.name;
        string tag = collision.gameObject.tag;



        Debug.Log("Entró en colision con: " + name);

        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            contE++;
            cuenta.txt_score.text = "Taipanes: "+contE.ToString();
            KillSonido.PlayOneShot(KillSound, 0.6f);
        }

        if (collision.gameObject.CompareTag("Grass"))
        {
            Destroy(collision.gameObject);
            contF++;
            cuenta.txt_feed.text = "Alimento: " + contF.ToString();
        }

        if (collision.gameObject.CompareTag("Egg"))
        {
            Destroy(collision.gameObject);
            contH++;
            cuenta.txt_eggs.text = "Huebos: " + contH.ToString();
        }




    }
}
