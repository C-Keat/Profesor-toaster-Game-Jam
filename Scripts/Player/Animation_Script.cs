using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Animation_Script : MonoBehaviour {

    Animator anim;

    public GameObject dead;

    private bool m_FacingRight = true;  // For determining which way the player is currently facing.
                                        // Use this for initialization
    private Transform m_GroundCheck;    // A position marking where to check if the player is grounded.
   

    void Start () {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("d") || Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (m_FacingRight != true)Flip();
            m_FacingRight = true;
           
        }
        else if (Input.GetKeyDown("a") || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (m_FacingRight == true) Flip();
            m_FacingRight = false;

            
        }
           
        if (Input.GetKeyDown("d") || Input.GetKeyDown("a") || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
        
            anim.SetBool("Moving", true);

        }
        else if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            anim.SetBool("Moving", false);
        }
        else if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            anim.SetBool("Moving", false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("Jumping", true);
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("Jumping", false);
        }

        if (dead.GetComponent<PlayerPlatformerController>().health == 0)
        {
            anim.SetBool("Dead", true);

        }
        if ((dead.GetComponent<PlayerPlatformerController>().health == 1))
        {
            anim.SetBool("Dead", false);
        }



    }

    private void Flip()
    {
        // Switch the way the player is labelled as facing.
        m_FacingRight = !m_FacingRight;

        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
