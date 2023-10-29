using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public GameObject mainMenuCanvas;
    public GameObject gameCanvas;
    public GameObject helpCanvas; 

    private void Start()
    {
        mainMenuCanvas.SetActive(true);
        gameCanvas.SetActive(false);
        helpCanvas.SetActive(false);
    }

    public void MainMenu()
    {
        mainMenuCanvas.SetActive(true);
        gameCanvas.SetActive(false);
        helpCanvas.SetActive(false);
    }

    public void GameScene()
    {
        mainMenuCanvas.SetActive(false);
        gameCanvas.SetActive(true);
        helpCanvas.SetActive(false);
    }

    public void HelpScreen()
    {
        mainMenuCanvas.SetActive(false);
        gameCanvas.SetActive(false);
        helpCanvas.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit(); 
    }
}
