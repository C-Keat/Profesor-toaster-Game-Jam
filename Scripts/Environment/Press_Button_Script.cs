using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Press_Button_Script : MonoBehaviour
{
    public GameObject dor;
    public bool pressed;
    public Sprite pushed;
    public Sprite unpushed;
    private SpriteRenderer current;
    public GameObject PushBot;
    public AudioClip pressButton;
    AudioSource audioSource;

    void Start()
    {
        current = gameObject.GetComponent<SpriteRenderer>();
        pressed = false;
        current.sprite = unpushed;
        audioSource = GetComponent<AudioSource>();

    }

    private void Update()
    {
        if (pressed == true)
            current.sprite = pushed;

            }

    private void OnTriggerEnter2D(Collider2D col)
    {
       
        Debug.Log("im being touched by " + col.gameObject.tag);
        if (col.gameObject.tag == "PushBot")
        {
            pressed = true;
            dor.GetComponent<Door>().PushMe();
            audioSource.PlayOneShot(pressButton);
        }
    }
}
   
