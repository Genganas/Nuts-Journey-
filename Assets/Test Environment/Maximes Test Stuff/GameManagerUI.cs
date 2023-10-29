using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManagerUI : MonoBehaviour
{
    [SerializeField] TMP_InputField userAge;
    [SerializeField] TMP_Text warningText;

    [SerializeField] public int userAgeInt;
    [SerializeField] string userAgeString;
    [SerializeField] public int userSexInt;
    [SerializeField] public int userLocation;

    [SerializeField] private GameObject sexHud;
    [SerializeField] private GameObject locationHud;
    [SerializeField] private GameObject ageHud;

    [SerializeField] private bool ageDone;
    [SerializeField] private bool locationDone;
    [SerializeField] private bool sexDone;

    private void Awake()
    {
        warningText.enabled = false;

        sexHud.SetActive(true);
        locationHud.SetActive(false);
        ageHud.SetActive(false);

        ageDone = false;
        locationDone = false;
        sexDone = false;
    }
    // Update is called once per frame
    void Update()
    {
        //converting player input into a string
        userAgeString = userAge.text;
        //converting string into an int if it is numerical values in the string
        if (int.TryParse(userAgeString, out userAgeInt))
        {
            userAgeInt = int.Parse(userAgeString);
            warningText.enabled = false;
        }
        else
        {
            warningText.enabled = true;
            warningText.text = "Enter an age please";
        }


        
        if(sexDone == true)
        {
            locationHud.SetActive(true);
        }

        if(ageDone == true)
        {
            ageHud.SetActive(true);
        }

    }

    public void ButtonPressSexChoiceMale()
    {
        userSexInt = 0;

        sexHud.SetActive(false);
        sexDone = true;
    }
    public void ButtonPressSexChoiceFemale()
    {
        userSexInt = 1;

        sexHud.SetActive(false);
        sexDone = true;
    }
    public void ButtonPressSexChoiceOther()
    {
        userSexInt = 2;

        sexHud.SetActive(false);
        sexDone = true;
    }

    public void ButtonPressLocationUrban()
    {
        userLocation = 0;

        locationHud.SetActive(false);
        locationDone = true;
    }

    public void ButtonPressLocationRural()
    {
        userLocation = 1;

        locationHud.SetActive(false);
        locationDone = true;
    }

    public void ButtonGoNext()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
