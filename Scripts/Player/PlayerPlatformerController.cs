using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPlatformerController : PhysicsObject
{
    public AudioClip JumpSound;
    public AudioClip deathSound;
    AudioSource audioSource;
    public float jumpTakeOffSpeed = 7;
    
    public float maxSpeed = 7;
   
    private GameObject porter;
    public int health;
    private GameObject respawn;
    public bool loadScene = false;

    //private int count;
    //public Text countText;
    // Use this for initialization
    void Start()
    {
        health = 1;
        respawn = GameObject.FindGameObjectWithTag("Spawn");
        audioSource = GetComponent<AudioSource>();
        //count = 0;
        // SetCountText();
    }
    

    protected override void ComputeVelocity()
    {
        Vector2 move = Vector2.zero;
        move.x = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump") && grounded)
        {
            velocity.y = jumpTakeOffSpeed;
            audioSource.PlayOneShot(JumpSound);

        }
        else if (Input.GetButtonUp("Jump"))
        {
            if (velocity.y > 0)
            {
                velocity.y = velocity.y * 0.5f;
            }
        }

        targetVelocity = move * maxSpeed;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Teleporter1")
        {
            Debug.Log("Touching teleporter 1");
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Using Teleporter 1");
                porter = GameObject.FindGameObjectWithTag("Teleporter2");
                this.transform.position = porter.transform.position;

            }

        }
        if (collision.tag == "Teleporter2")
        {
            Debug.Log("Touching teleporter 2");
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Using Teleporter 2");
                porter = GameObject.FindGameObjectWithTag("Teleporter1");
                this.transform.position = porter.transform.position;

            }
        }
        if (collision.tag == "Teleporter3")
        {
            Debug.Log("Touching teleporter 3");
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Using Teleporter 3");
                porter = GameObject.FindGameObjectWithTag("Teleporter4");
                this.transform.position = porter.transform.position;

            }

        }
        if (collision.tag == "Teleporter4")
        {
            Debug.Log("Touching teleporter 4");
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Using Teleporter 4");
                porter = GameObject.FindGameObjectWithTag("Teleporter3");
                this.transform.position = porter.transform.position;

            }


        }
        if (collision.tag == "Teleporter5")
        {
            Debug.Log("Touching teleporter 5");
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Using Teleporter 5");
                porter = GameObject.FindGameObjectWithTag("Teleporter6");
                this.transform.position = porter.transform.position;

            }


        }
        if (collision.tag == "Teleporter6")
        {
            Debug.Log("Touching teleporter 6");
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Using Teleporter 6");
                porter = GameObject.FindGameObjectWithTag("Teleporter5");
                this.transform.position = porter.transform.position;

            }


        }
        if (collision.tag == "Spikes")
            {
                Debug.Log("Touching Spikes");
                health = 0;
                if (health == 0) { Die(); }
            }
            if (collision.tag == "Shells"|| collision.tag == "Shells2"|| collision.tag == "Shells3")
            {
                Debug.Log("Touching Shells");
                health = 0;
                if (health == 0) { Die(); }
            }


            if (collision.tag == "NextScene")
            {
                loadScene = true;
            }

        
    }
    void Die()
    {
        audioSource.PlayOneShot(deathSound);
        this.gameObject.transform.position = respawn.transform.position;
        health = 1;
    }

    

    /*
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Pickup"))
        {
            collision.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
    }*/

}
