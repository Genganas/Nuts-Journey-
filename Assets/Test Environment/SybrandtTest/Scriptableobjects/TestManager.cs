using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestManager : MonoBehaviour
{
    [SerializeField] int age;
    [SerializeField] LifeEventsManager lifeEventsManager;

    Event activeEvent;
    private void Start()
    {
        activeEvent = lifeEventsManager.GetNewEvent(age);
        Debug.Log(activeEvent.lifeEvent.eventName);
        //StartCoroutine(Delay());
    }

    //IEnumerator Delay()
    //{
    //    yield return new WaitForSeconds(5f);
        
    //}
}
