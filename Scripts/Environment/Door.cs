using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    public bool openD;
    public Sprite Open;
    public Sprite almostOpen;
    public Sprite almostClosed;
    public Sprite Closed;
    private SpriteRenderer current;
    public int ButtonsOP;
    public int qwert;
    public bool openingSound = false;

    Animator anim;
    public AudioClip openSound;
    AudioSource audioSource;

    void Start()
       {
        current = gameObject.GetComponent<SpriteRenderer>();
        openD = false;
        current.sprite = Closed;
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {

        bool isOpen = openD;
        if( qwert >= ButtonsOP)
        {
            isOpen = true;
            GetComponent<BoxCollider2D>().enabled = false;
        }
        else
        {
            isOpen = false;
            GetComponent<BoxCollider2D>().enabled = true;
        }

            if (isOpen == false)
        {
            anim.SetBool("open", false);
            

        }
        else
        {

            anim.SetBool("open", true);
            if (isOpen != openD)
            {
                audioSource.PlayOneShot(openSound);
            }

        }
        openD = isOpen;
    }
    public void PushMe() { qwert++; }
    public void UnPushMe() { qwert--; }

   
}
