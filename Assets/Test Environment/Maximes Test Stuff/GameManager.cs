using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("User Info")]
    [SerializeField] private string userLocation;
    [SerializeField] private bool userLocationBool;
    [SerializeField] private string userSex;
    [SerializeField] private int userSexInt;
    [SerializeField] private int userAge;

    [Header("Character")]
    [SerializeField] private string characterName;
    [SerializeField] private int characterSex;
    [SerializeField] private int characterHealth;
    [SerializeField] private int characterRiskFactor;
    [SerializeField] private int characterHappiness;

    [SerializeField] private int characterMaxHealth;
    [SerializeField] private int characterMaxRiskFactor;
    [SerializeField] private int characterMaxHappiness;

    [Header("Genreal")]
    [SerializeField] GameObject GameManagerObj;
    [SerializeField] GameManagerUI gameManagerUI;

    //Awake is called as the script activates
    private void Awake()
    {
        //sets character stats immediately
        CharacterRandomStartStats();



        Scene scene = SceneManager.GetActiveScene();

        if (scene.name == "Test Scene")
        {
            gameManagerUI = GameManagerObj.GetComponent<GameManagerUI>();
        }
    }

        // Start is called before the first frame update
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CharacterStatMax();
        CharacterSexRandomChoice();


    }

    void PlayerRealWordLocation()
    {
        userLocation = gameManagerUI.userLocation.ToString();
    }

    void UserSex()
    {
        userSexInt = gameManagerUI.userSexInt;

        switch (userSexInt)
        {
            case 0:
                userSex = "Male";
                break;

            case 1:
                userSex = "Female";
                break;

            case 2:
                userSex = "Other";
                break;

            default:
                userSex = "Other";                
                break;
        }
    }

    void UserAge()
    {
        userAge = gameManagerUI.userAgeInt;
    }

    void CharacterStatMax()
    {
        if(characterHealth > characterMaxHealth)
        {
            characterHealth = characterMaxHealth;
        }

        if(characterHappiness > characterMaxHappiness)
        {
            characterHappiness = characterMaxHappiness;
        }

        if(characterRiskFactor > characterMaxRiskFactor)
        {
            characterRiskFactor = characterMaxRiskFactor;
        }
    }

    void CharacterRandomStartStats()
    {
        //Setting the characters starting stats at Random
        characterHappiness = Random.Range(45, 56);
        characterRiskFactor = Random.Range(0, 11);
        characterHealth = Random.Range(45, 56);

        //setting the charactername
        CharacterNameStorage();
    }

    void CharacterNameStorage()
    {
        int characterNameRandom = Random.Range(0, 10);
        
        switch (characterNameRandom)
        {
            case 0:
                if (characterSex == 0)//Male
                {
                    characterName = "Lethabo";
                }
                else//Female
                {
                    characterName = "Amahle";
                }
                break;

            case 1:
                if (characterSex == 0)//Male
                {
                    characterName = "Lubanzi";

                }
                else//Female
                {
                    characterName = "Omphile";
                }
                break;
            case 2:
                if (characterSex == 0)//Male
                {
                    characterName = "Siphosethu";

                }
                else//Female
                {
                    characterName = "Lisakhanya";
                }
                break;

            case 3:
                if (characterSex == 0)//Male
                {
                    characterName = "Johannes";

                }
                else//Female
                {
                    characterName = "Elizabeth";
                }
                break;

            case 4:
                if (characterSex == 0)//Male
                {
                    characterName = "Daniel";

                }
                else//Female
                {
                    characterName = "Anna";
                }
                break;

            case 5:
                if (characterSex == 0)//Male
                {
                    characterName = "William";

                }
                else//Female
                {
                    characterName = "Sarah";
                }
                break;

            case 6:
                if (characterSex == 0)//Male
                {
                    characterName = "Blessing";
                }
                else//Female
                {
                    characterName = "Gift";
                }
                break;

            case 7:
                if (characterSex == 0)//Male
                {
                    characterName = "Prince";

                }
                else//Female
                {
                    characterName = "Princess";
                }
                break;
            case 8:
                if (characterSex == 0)//Male
                {
                    characterName = "Gavin";
                }
                else//Female
                {
                    characterName = "Abigail";
                }
                break;

            case 9:
                if (characterSex == 0)//Male
                {
                    characterName = "Damian";
                }
                else//Female
                {
                    characterName = "Deidre";
                }
                break;

            default:
                if (characterSex == 0)//Male
                {
                    characterName = "Aiden";
                }
                else//Female
                {
                    characterName = "Leschan";
                }
                break;
        }
    }

    void CharacterSexChoiceMale()
    {
        characterSex = 0;
    }

    void CharacterSexChoiceFemale()
    {
        characterSex = 1;
    }

    void CharacterSexRandomChoice()
    {
        if (characterSex != 0 || characterSex != 1 )
        {
            characterSex = Random.Range(1, 2);
        }
    }

}//end of script
