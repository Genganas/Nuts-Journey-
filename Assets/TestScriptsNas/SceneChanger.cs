using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
    public void GameplayScene()  //Loads the Game or scene which the game will start with
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void OptionsScene()// Loads the Options scene
    {
        SceneManager.LoadScene("OptionsMenu");
    }
    public void CharacterCreatorScene()// Loads the Options scene
    {
        SceneManager.LoadScene("CharacterCreate");
    }
    public void MainMenu() // Loads the menu scene
    {
        //Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
        
    }
    public void Credits() // Loads the Credits scene 
    {
        SceneManager.LoadScene("Credits");
    }
    public void Quit() // Quits the game 
    {
        Application.Quit();
    }

    public void CHeckpointRace() // Loads the checkpoint race
    {
        SceneManager.LoadScene("CheckPointRace");
    }
    public void BeginnerRace() // Loads the advanced race
    {
        SceneManager.LoadScene("BeginnerRace");
    }
    public void CHeckpointDialogue() // Loads the chekpoint race dialogue
    {
        SceneManager.LoadScene("CheckPointDialogue");
    }

    public void BeginnerDialogue() // Loads the beginner race dialogue
    {
        SceneManager.LoadScene("BeginnerRaceDialogue");
    }

    public void AdvancedDialogue() // Loads the advanced race dialogue
    {
        SceneManager.LoadScene("AdvancedRaceDialogue");
    }
}