using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    [SerializeField] private AudioSource Enter;
    [SerializeField] private AudioSource Exit;
    void Start()
    {


    }

    void Update()
    {

        
    }
    private void OnTriggerEnter(Collider other)
    {
        Enter.Play();
        Exit.Stop();
    }
    private void OnTriggerExit(Collider other)
    {
        Exit.Play();
        Enter.Stop();
    }
}
