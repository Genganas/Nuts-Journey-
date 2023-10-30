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


    Event activeEvent;
    private void Update()
    {
        Debug.Log("Seeking Game Manager");
        gameManagerOBJ = GameObject.Find("GameManager");
        gameManager = gameManagerOBJ.GetComponent<GameManager>();

        age = gameManager.characterAgeInt;

        activeEvent = lifeEventsManager.GetNewEvent(age);
            Debug.Log(activeEvent.lifeEvent.eventName);
            //StartCoroutine(Delay());





    }

    //IEnumerator Delay()
    //{
    //    yield return new WaitForSeconds(5f);

    //}
}
