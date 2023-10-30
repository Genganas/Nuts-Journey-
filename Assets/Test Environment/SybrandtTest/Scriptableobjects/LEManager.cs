using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LEManager : MonoBehaviour
{
    [Header("General")]
    [SerializeField] int age;
    [SerializeField] LifeEventsManager lifeEventsManager;

    [Header("Game Manager")]
    [SerializeField] GameObject gameManagerOBJ;
    [SerializeField] GameManager gameManager;

    [Header("UI")]
    [SerializeField] UIManager uiManager;


    Event activeEvent;
    private void Awake()
    {
        uiManager = GetComponent<UIManager>();
    }
    private void Update()
    {
        Debug.Log("Seeking Game Manager");

        if(gameManagerOBJ == null ) 
        {
            gameManagerOBJ = GameObject.Find("GameManager");
            gameManager = gameManagerOBJ.GetComponent<GameManager>();
            SetAge();
            activeEvent = lifeEventsManager.GetNewEvent(age);
            uiManager.UpdateUI(activeEvent);
        }
    }

    public void SetAge()
    {
        age = gameManager.characterAgeInt;
    }

    public void OptionSelected()
    {
        gameManager.IncreaseAge();
        SetAge();
        activeEvent = lifeEventsManager.GetNewEvent(age);
        uiManager.UpdateUI(activeEvent);
    }
    //IEnumerator Delay()
    //{
    //    yield return new WaitForSeconds(5f);

    //}
}
