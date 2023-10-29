using UnityEngine;
using UnityEngine.UI;

public class CanvasSwitch : MonoBehaviour
{
    public GameObject mainMenuCanvas;
    public GameObject optionCanvas;
    public GameObject helpCanvas; 

    private void Start()
    {
        mainMenuCanvas.SetActive(true);
        optionCanvas.SetActive(false);
        helpCanvas.SetActive(false);
    }

    public void MainMenu()
    {
        mainMenuCanvas.SetActive(true);
        optionCanvas.SetActive(false);
        helpCanvas.SetActive(false);
    }

    public void OptionScreen()
    {
        mainMenuCanvas.SetActive(false);
        optionCanvas.SetActive(true);
        helpCanvas.SetActive(false);
    }

    public void HelpScreen()
    {
        mainMenuCanvas.SetActive(false);
        optionCanvas.SetActive(false);
        helpCanvas.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit(); 
    }
}
