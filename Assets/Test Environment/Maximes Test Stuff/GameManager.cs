using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("User Info")]
    [SerializeField] public string userLocation;
    [SerializeField] private bool userLocationBool;
    [SerializeField] public string userSex;
    [SerializeField] public int userSexInt;
    [SerializeField] public int userAge;

    [Header("Character")]
    [SerializeField] private string characterName;
    [SerializeField] private  int characterSex;
    [SerializeField] private  int characterHealth;
    [SerializeField] private  int characterRiskFactor;
    [SerializeField] private  int characterHappiness;

    [SerializeField] private  int characterMaxHealth;
    [SerializeField] private  int characterMaxRiskFactor;
    [SerializeField] private  int characterMaxHappiness;

    [Header("Genreal")]
    [SerializeField] GameObject GameManagerObj;
    [SerializeField] GameManagerUI gameManagerUI;
    
    public static GameManager Instance;

    //Awake is called as the script activates
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(Instance);
        }
        else
        {
            Destroy(Instance);
        }



        Scene scene = SceneManager.GetActiveScene();


        gameManagerUI = GameManagerObj.GetComponent<GameManagerUI>();

    }

        // Start is called before the first frame update
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CharacterStatMax();
        CharacterSexChoice();

        UserInformation();

        loadGameScene();
        
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

    void CharacterSexChoice()
    {
        if(gameManagerUI.CharacterSexInt == 0)
        {
            characterSex = 0;
        }
        else if( gameManagerUI.CharacterSexInt == 1)
        {
            characterSex = 1;
        }
    }
    
    void loadGameScene()
    {
        if(gameManagerUI.readyToPlay == true)
        {
            //sets character stats immediately
            CharacterRandomStartStats();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }



    }

    void UserInformation()
    {
        userAge = gameManagerUI.userAgeInt;
        
        if(gameManagerUI.userSexInt == 0)
        {
            userSex = "Male";
            userSexInt = 0;
        }
        else
        {
            if (gameManagerUI.userSexInt == 1)
            {
                userSex = "Female";
                userSexInt = 1;
            }
        }

       if(gameManagerUI.userLocation == 0)
        {
            userLocation = "Urban";

        }
        else
        {
            userLocation = "Rurual";
        }
    }


}//end of script
