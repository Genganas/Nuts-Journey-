using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAccess : MonoBehaviour
{
    Audio_Manager audio_Manager;

    private void Update()
    {
        if(audio_Manager == null)
        {
            audio_Manager = GameObject.FindAnyObjectByType<Audio_Manager>();
        }
    }

    public void CallManager()
    {
        audio_Manager.ActivateAudioSource(GameObject.Find("ButtonAudio").GetComponent<AudioSource>());
    }
}
