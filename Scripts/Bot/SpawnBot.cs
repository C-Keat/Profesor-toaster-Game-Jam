using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBot : MonoBehaviour {

    public BotMovement botMovement1;
    public BotMovement botMovement2;
    public BotMovement botMovement3;
    public BotMovement botMovement4;
    public bool facingRight = true;
    public GameObject PushBot;
    public GameObject BlockBot;
    public GameObject ShieldBot;
    public GameObject BridgeBot;
    public GameObject EmptySpaceCheck;
    public bool canIspawn = true;
    public bool spawnFailed = false;
    public bool BotFacingRight = true;
    public float TimeLeft = 3f;
    public int BotAllocation;
    public int MaxBots;

    
	// Use this for initialization
	void Start () {
        StartCoroutine(timer());
        //GameObject.EmptySpaceCheck = GetComponent<FreeSpaceCheck>();
       // botMovement = GetComponent<BotMovement>();
      // PushBot =  GameObject.FindGameObjectWithTag("PushBot");
	}

    // Update is called once per frame
    void Update() {

        if (Input.GetKeyDown("d"))
        {
            facingRight = true;
            BotFacingRight = true;
}
        if (Input.GetKeyDown("a"))
        {
            facingRight = false;
         BotFacingRight = false;
           
        }




        if (facingRight == true)
        {
            Spawn(false, +0.9f);
        }
        else
        {
            Spawn(true, -0.9f);
        }

    }
    void Spawn(bool facing, float position)
    {
        // Debug.Log("Im facing right");
        if (canIspawn == true && BotAllocation < MaxBots && TimeLeft < 1.0f)
        {
            // Debug.Log("I can spawn;");
            spawnFailed = false;

            botMovement1.moveLeft = facing;
            botMovement2.moveLeft = facing;
            botMovement3.moveLeft = facing;
            botMovement4.moveLeft = facing;
            // Debug.Log(botMovement.moveLeft);
           
            
            
                if (Input.GetKeyDown(KeyCode.Alpha1))
                {
                    if (BotFacingRight == true) PushBot.transform.localScale = new Vector3(2, 2, 2);
                    if (BotFacingRight == false) PushBot.transform.localScale = new Vector3(-2, 2, 2);
                    Instantiate(PushBot, new Vector2(this.transform.position.x + position, this.transform.position.y), this.transform.rotation);
                    BotAllocation++;
                // Debug.Log("i summond a bot");
                TimeLeft = 2.5f;
                    
                }
                if (Input.GetKeyDown(KeyCode.Alpha2))
                {
                    if (BotFacingRight == true) BlockBot.transform.localScale = new Vector3(2, 2, 2);
                    if (BotFacingRight == false) BlockBot.transform.localScale = new Vector3(-2, 2, 2);
                    Instantiate(BlockBot, new Vector2(this.transform.position.x + position, this.transform.position.y), this.transform.rotation);
                    BotAllocation++;
                // Debug.Log("i summond a bot");
                TimeLeft = 2.5f;

            }
                if (Input.GetKeyDown(KeyCode.Alpha3))
                {
                    if (BotFacingRight == true) ShieldBot.transform.localScale = new Vector3(2, 3, 2);
                    if (BotFacingRight == false) ShieldBot.transform.localScale = new Vector3(-2, 3, 2);
                    Instantiate(ShieldBot, new Vector2(this.transform.position.x + position, this.transform.position.y), this.transform.rotation);
                    BotAllocation++;
                // Debug.Log("i summond a bot");
                TimeLeft = 2.5f;
            }
                if (Input.GetKeyDown(KeyCode.Alpha4))
                {
                    if (BotFacingRight == true) BridgeBot.transform.localScale = new Vector3(2, 2, 2);
                    if (BotFacingRight == false) BridgeBot.transform.localScale = new Vector3(-2, 2, 2);
                    Instantiate(BridgeBot, new Vector2(this.transform.position.x + position, this.transform.position.y), this.transform.rotation);
                    BotAllocation++;
                //Debug.Log("i summond a bot");
                TimeLeft = 2.5f;

            }
                
                
                
             

                
                
            
        }
        else
        {
            spawnFailed = true;
        }

        if (TimeLeft > 0.0f)
        {
            TimeLeft -= Time.deltaTime;
        }
    }

    IEnumerator timer()
    {

    
        yield return new WaitForSeconds(2.5f);
        botDestroyed();
        StartCoroutine(timer());
        

    }


    public void botDestroyed()
    {
        Debug.Log("called bot destroyed");
        if (BotAllocation == 0)
        {
            return;
        }
        else
        {
            BotAllocation--;
        }
    }
}


       

    

