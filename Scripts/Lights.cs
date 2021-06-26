using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights : MonoBehaviour
{

    public bool On;
    public Sprite green;
    public Sprite red;
    private SpriteRenderer current;

    void Start()
    {
        current = gameObject.GetComponent<SpriteRenderer>();
        On = false;
        current.sprite = red;

    }

    private void Update()
    {
        if (On == true) current.sprite = green;
        if (On == false) current.sprite = red;
    }
    private void OnTriggerEnter2D()
    {
        if (On == true) current.sprite = green;

    }
    private void OnTriggerExit2D()
    {
        if (On == false) current.sprite = red;

    }



}