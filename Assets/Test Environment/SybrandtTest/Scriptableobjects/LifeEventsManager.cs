using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LifeEventsManager : MonoBehaviour
{
    [SerializeField] List<Event> lifeEvents = new List<Event>();

    List <Event> activeYearLifeEvents = new List<Event>();
    private void Start()
    {
        Debug.Log(lifeEvents);
    }

    public Event GetNewEvent(int age)  //
    {
        return GenerateActiveYearEvent(age);
    }

    private Event GenerateActiveYearEvent(int age)
    {

        activeYearLifeEvents.Clear();

        for (int i = 0; i < lifeEvents.Count; i++)
        {
            if (lifeEvents[i].lifeEvent.activeYear == age)
            {
                activeYearLifeEvents.Add(lifeEvents[i]);
                
            }
        }

        int numberOfEvents = activeYearLifeEvents.Count;
        int randomEventSelect = Random.Range(0, numberOfEvents);

        return activeYearLifeEvents[randomEventSelect];
    }
}
