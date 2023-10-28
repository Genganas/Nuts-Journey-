using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Manager : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;

    public void PlayClip(AudioSource audioSource, AudioClip clipToPlay)
    {
        audioSource.clip = clipToPlay;
        audioSource.Play();
    }

    public void ActivateAudioSource(AudioSource audioSource)
    {
        audioSource.Play();
    }
   
}
