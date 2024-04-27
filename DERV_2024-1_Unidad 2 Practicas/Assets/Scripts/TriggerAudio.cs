using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAudio : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip audioClip;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        audioSource.Play();
        audioSource.loop = true;
    }

    private void OnTriggerExit(Collider other)
    {
        audioSource.Stop();
        audioSource.loop=false;
    }
}
