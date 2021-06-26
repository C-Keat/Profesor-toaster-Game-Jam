using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SceneLoader : MonoBehaviour
{
    public Scene activeScene;
    public Text botControls1;
    public Text botControls2;
    public Text botControls3;
    public Text botControls4;
    public Button start;
    public Button controls;
    public Button back;
    public Text timer;
    public Button reset;
    //private TimerScript timerScript;
    public int sceneIndex = 1;
    public PlayerPlatformerController player;
    public NextLevel nextLevel;
    public GameObject controlspic;
    //public GameObject bg;
    private void OnEnable()
    {

        SceneManager.sceneLoaded += OnSceneLoaded;

    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        player = GetComponent<PlayerPlatformerController>();
        nextLevel = GetComponent<NextLevel>();
        activeScene = SceneManager.GetActiveScene();
        Debug.Log(activeScene.name);
        if (activeScene.name == "Menu")
        {
            ToggleUI(start.gameObject, 1);
            ToggleUI(controls.gameObject, 1);
            ToggleUI(back.gameObject, 0);
            ToggleUI(botControls1.gameObject, 0);
            ToggleUI(botControls2.gameObject, 0);
            ToggleUI(botControls3.gameObject, 0);
            ToggleUI(botControls4.gameObject, 0);
            //ToggleUI(timer.gameObject, 0);
            ToggleUI(reset.gameObject, 0);
            //timerScript.paused = true;
            ToggleUI(controlspic, 0);
            //ToggleUI(bg.gameObject, 0);
        }

        if (activeScene.name == "Tutorial Level" || activeScene.name == "Level1" || activeScene.name == "Level2")
        {
            ToggleUI(start.gameObject, 0);
            ToggleUI(controls.gameObject, 0);
            ToggleUI(back.gameObject, 0);
            ToggleUI(botControls1.gameObject, 1);
            ToggleUI(botControls2.gameObject, 1);
            ToggleUI(botControls3.gameObject, 1);
            ToggleUI(botControls4.gameObject, 1);
            //ToggleUI(bg.gameObject, 1);

            //ToggleUI(timer.gameObject, 1);
            ToggleUI(reset.gameObject, 1);
            //timerScript.paused = false;

        }
        if (activeScene.name == "Tutorial Level")
        {
            // timerScript = GetComponent<TimerScript>();

        }

    }

    // Use this for initialization
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);

    }

    //private void FixedUpdate()
    //{
    //    if(player.loadScene == true)
    //    {
    //        player.loadScene = false;
    //        sceneIndex++;
    //        SceneManager.LoadScene(sceneIndex);
    //    }

    //}
    public void StartButtonPressed()
    {
        SceneManager.LoadScene("Tutorial Level");
        // SceneManager.UnloadSceneAsync(activeScene);
    }

    public void ControlsbuttonPressed()
    {
        ToggleUI(start.gameObject, 0);
        ToggleUI(controls.gameObject, 0);
        ToggleUI(back.gameObject, 1);
        ToggleUI(controlspic, 1);

        //ToggleUI(timer.gameObject, 1);

    }

    public void resetButtonPressed()
    {
        Debug.Log(activeScene.name);
        nextLevel = GetComponent<NextLevel>();

       // nextLevel.sceneIndex = 1;
        // SceneManager.UnloadSceneAsync(activeScene);
        // SceneManager.LoadScene("Menu");
        SceneManager.LoadScene(0);


    }


    public void BackbuttonPressed()
    {
        ToggleUI(start.gameObject, 1);
        ToggleUI(controls.gameObject, 1);
        ToggleUI(back.gameObject, 0);
        ToggleUI(controlspic, 0);

        //ToggleUI(timer.gameObject, 0);

    }

    /// <summary>
    /// Switches UI active state. Pass the element as "NameofUi".gameObject, and either 0 for false, and 1 for true
    /// </summary>
    GameObject ToggleUI(GameObject toggleMe, int id)
    {
        if (id == 1)
        {
            toggleMe.gameObject.SetActive(true);
        }
        if (id == 0)
        {
            toggleMe.gameObject.SetActive(false);
        }

        return toggleMe;

    }

}
