using UnityEngine;
using UnityEngine.UI;

public class ButtonSound : MonoBehaviour
{
    public Button yourButton;     // Reference to your button
    public AudioSource clickSound; // Reference to the AudioSource 

    private void Start()
    {
        yourButton.onClick.AddListener(PlayButtonClickSound);
    }

    private void PlayButtonClickSound()
    {
        clickSound.Play();
    }
}
