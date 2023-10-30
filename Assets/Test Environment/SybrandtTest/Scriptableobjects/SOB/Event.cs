using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

[System.Serializable]
public struct LifeEvent
{
    [TextArea(2, 5)]
    public string eventName;
    [TextArea(2, 5)]
    public string eventContent;
    [TextArea(2, 5)]
    public string eventOption1;
    [TextArea(2, 5)]
    public string eventOption2;

    [Header("Life Effect")]
    public float healthEffect;
    public float riskEffect;
    public float happienessEffect;

    [Header("Year in which event can take place")]
    public int activeYear; //Temp for demo but can be functional

}

[CreateAssetMenu(fileName = "New Event", menuName = "EventSOB")]
public class Event : ScriptableObject
{
    public LifeEvent lifeEvent;
}
