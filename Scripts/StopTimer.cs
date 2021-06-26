using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StopTimer : MonoBehaviour {

    public void Update()
    {
        if (Input.GetKeyDown("P"))
        {
            SceneManager.LoadScene(1);
        }
    }
  
}
