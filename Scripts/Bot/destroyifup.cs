using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyifup : MonoBehaviour {

    private float currentHight;
    private float killHeight;

    private void Start()
    {
      
        Transform myl = this.transform;
        killHeight = myl.transform.position.y;
    }
    void Update () {

        currentHight = this.transform.position.y;
       
        if (currentHight >= killHeight + 0.02f)
        {
          
            Destroy(this.gameObject);
        }
    }
}
