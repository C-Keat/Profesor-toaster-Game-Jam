using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBotSpike : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Spikes")
        {
            Destroy(this.gameObject);
        }
    }
}
