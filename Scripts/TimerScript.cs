using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TimerScript : SceneLoader
{
    private float startTimer;
     //public Text timer;
    private bool finished = false;
    public bool paused;
    private float gameTimer;
    public float T;
    // Use this for initialization
    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        activeScene = SceneManager.GetActiveScene();
        Debug.Log(activeScene.name);
        Debug.Log(paused);
        if (activeScene.name == "Menu")
        {
            paused = true;
            T = 0;
        }
        if (activeScene.name == "Tutorial Level")
        {
            paused = false;
        }

        // startTimer = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (finished)
        {
            return;
        }


        if (paused == false)
        {
            T = gameTimer += Time.deltaTime;
            //float T = Time.time - startTimer;
            string minutes = ((int)T / 60).ToString();
            string second = (T % 60).ToString("f0");
            timer.text = minutes + ":" + second;
            Debug.Log(T);

        }
    }

    public void finish()
    {
        finished = true;
        timer.color = Color.red;
    }


    private void OnTriggerEnter(Collider other)
    {
        GameObject.FindGameObjectsWithTag("stopTimer");
    }
}

