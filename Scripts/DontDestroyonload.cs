using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroyonload : MonoBehaviour {

   //public bool iExist = false;
    //public GameObject foo;
    // Use this for initialization
    void Start () {

       // iExist = true;
        DontDestroyOnLoad(this.gameObject);
	}

 //   void OnSceneLoaded(Scene scene, LoadSceneMode mode)
 //   {
 //       if (scene.name == "Menu")
 //       {
 //           Destroy(this.gameObject);
 //           return;
 //       }
 //   }

}
