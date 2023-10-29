using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Manager : MonoBehaviour
{

    public void PlayClip(AudioSource audioSource, AudioClip clipToPlay)  //Swaps out audio clips and plays them
    {
        audioSource.clip = clipToPlay;
        audioSource.Play();
    }

    public void ActivateAudioSource(AudioSource audioSource) //Activates audiosources that have clips assigned to them
    {
        audioSource.Play();
    }
   
}
