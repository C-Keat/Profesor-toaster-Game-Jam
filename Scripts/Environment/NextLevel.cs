﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class NextLevel : MonoBehaviour
{
    public int sceneIndex;


  

    private void OnTriggerEnter2D(Collider2D collision)
    {
       // sceneIndex++;
        SceneManager.LoadScene(sceneIndex);
    }
}


