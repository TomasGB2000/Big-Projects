using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{  //Assigning Audio to Events
    private AudioSource _soundSource;
    private AudioClip _shootSound;

    void Start()
    {   //Assigning Sound Clips to assigned events
        _soundSource = GetComponent<AudioSource>();
        _shootSound = Resources.Load("Lmg_fire 01") as AudioClip;
    }


    void Update()
    {

    }
    //Assigning Clips to be used in other scripts
    public void playShootSound()
    {
        _soundSource.PlayOneShot(_shootSound);
    }
}
