using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [Header("UI Components")]
    [SerializeField] TextMeshProUGUI eventName;
    [SerializeField] TextMeshProUGUI content;
    [SerializeField] TextMeshProUGUI option1;
    [SerializeField] TextMeshProUGUI option2;

    public void UpdateUI(Event currentEvent)
    {
        eventName.text = currentEvent.lifeEvent.eventName;
        content.text = currentEvent.lifeEvent.eventContent;
        option1.text = currentEvent.lifeEvent.eventOption1;
        option2.text = currentEvent.lifeEvent.eventOption2;
    }
}
