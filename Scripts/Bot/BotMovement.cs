using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BotMovement : PhysicsObject
{
    public GameObject player;
    SpawnBot spawnbot;
    public bool moveLeft ;
    public int maxLifeTime;
   // public bool touchedPlayer = false;
    public float jumpTakeOffSpeed = 1;
    public float maxSpeed = 1;


     void Start()
    {

        Destroy(gameObject, maxLifeTime);
       
    }

   
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (this.gameObject.tag == "PushBot")
        {
            
           if (collision.gameObject.tag == "PushBot" || collision.gameObject.tag == "BlockBot" || collision.gameObject.tag == "ShieldBot" || collision.gameObject.tag == "SpikeBot"||collision.gameObject.tag=="Spikes" || collision.gameObject.tag == "Shells") { Destroy(gameObject, 0); }
        }
        if (this.gameObject.tag == "BlockBot")
        {
            if (collision.gameObject.tag == "PushBot" || collision.gameObject.tag == "BlockBot" || collision.gameObject.tag == "ShieldBot" || collision.gameObject.tag == "SpikeBot"||collision.gameObject.tag == "Spikes" || collision.gameObject.tag == "Shells") { Destroy(gameObject, 0); }
        }
        if (this.gameObject.tag == "ShieldBot")
        {
            if (collision.gameObject.tag == "PushBot" || collision.gameObject.tag == "BlockBot" || collision.gameObject.tag == "ShieldBot" || collision.gameObject.tag == "SpikeBot"||collision.gameObject.tag == "Spikes") { Destroy(gameObject, 0); }
            if (this.gameObject.tag == "ShieldBot" && collision.gameObject.tag == "Shells") { return; }

        }
        if (this.gameObject.tag == "SpikeBot")
        {
            if (collision.gameObject.tag == "PushBot" || collision.gameObject.tag == "BlockBot" || collision.gameObject.tag == "ShieldBot" || collision.gameObject.tag == "SpikeBot"|| collision.gameObject.tag == "Shells") { Destroy(gameObject, 0); }
            if (this.gameObject.tag == "SpikeBot" && collision.gameObject.tag == "Spikes") { return; }
        }
       /* Debug.Log("called");
        if (collision.gameObject.tag != "Player" && collision.gameObject.tag != "Wall" && collision.gameObject.tag != "Untagged" && collision.gameObject.tag != "Press Button" && collision.gameObject.tag != "OffButton" && collision.gameObject.tag != "OnButton") 
        {
           
            Debug.Log("called 2"+this.gameObject.tag+"  " + collision.gameObject.tag);
            Destroy(gameObject, 0);


        }*/
        /*
        moveLeft = !moveLeft;
        Debug.Log("I hit a wall");
    }
    if (collision.gameObject.tag == "player")
    {
        touchedPlayer = true;
        Debug.Log("I touched the player");
        combatManager.enemytofightlocal = this.gameObject;
        combatManager.localEnemyName = this.gameObject.name;
        //Debug.Log(enemyToFight.name);
        SceneManager.LoadScene("Combat");
    }
    */
    }

    


    protected override void ComputeVelocity()
    {

        Debug.Log("im moving " + moveLeft + "false = right");
        Vector2 move = Vector2.zero;

        if (moveLeft == true)
        {
            move.x = -1;//left
        }
        if (moveLeft == false)
        {
            move.x = 1;//right
        }

        targetVelocity = move * maxSpeed;
      
    }
}