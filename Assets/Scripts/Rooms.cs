using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rooms : MonoBehaviour
{
    [SerializeField] private AudioSource audiosource;
    [SerializeField] private Sounds music;

    private void OnTriggerEnter(Collider other)
    {
       audiosource.clip = music.SoundClip;
       audiosource.Play();
    }
    private void OnTriggerExit(Collider other)
    {
       audiosource.clip = music.SoundClip;
       audiosource.Stop();
    }

}
