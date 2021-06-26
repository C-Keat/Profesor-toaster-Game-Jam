using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push_Button_Script : MonoBehaviour
{
    public GameObject dor;
    public bool pressed;
    public Sprite held;
    public Sprite unheld;
    private SpriteRenderer current;
    public int qwert;

    void Start()
    {
        current = gameObject.GetComponent<SpriteRenderer>();
        pressed = false;
        current.sprite = unheld;

    }

    private void Update()
    {
       
        if (pressed == true)
        { 
            current.sprite = held;
            transform.gameObject.tag = "OnButton";
        }
        if (pressed == false)
        {
            current.sprite = unheld;
            transform.gameObject.tag = "OffButton";

        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
       
        Debug.Log("im being touched by " + collision.gameObject.tag);
        if (collision.tag == "PushBot")
        {
            pressed = true;
            dor.GetComponent<Door>().PushMe();
            current.sprite = held;
            transform.gameObject.tag = "OnButton";
           
        }

        if (collision.tag != "PushBot" || collision.tag != null)
        {
            Debug.Log("im not being touched");
            pressed = false;
            dor.GetComponent<Door>().UnPushMe();
            current.sprite = unheld;
            transform.gameObject.tag = "OffButton";
        }
       

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        
        Debug.Log("im being touched by " + collision.tag);
        if (collision.tag == "PushBot")
        {
            pressed = false;
            dor.GetComponent<Door>().UnPushMe();
        }
    }


}
