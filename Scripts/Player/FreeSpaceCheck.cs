//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class FreeSpaceCheck : MonoBehaviour {

//   // public bool canSpawn = true;
//    GameObject SpawnBot;
//    public SpawnBot spawnbot;
//   // public Text cantspawnmsg;
//    Rigidbody2D rb2d;
//    public float MaxRayDist;

//    // Use this for initialization
//    void Start () {
//        GameObject Player = GameObject.Find("Player");
//        spawnbot = Player.GetComponent<SpawnBot>();
//        //cantspawnmsg = GameObject.FindGameObjectWithTag("CantSpawnMsg").GetComponent<UnityEngine.UI.Text>();
//        //ToggleUI(cantspawnmsg.gameObject, 0);

//        rb2d = GetComponent<Rigidbody2D>();

//        //  StartCoroutine(toggleTimer());
//        Debug.Log("Spawned");
        
//	}





	
//	// Update is called once per frame
//	/*void Update () {
//        if (spawnbot.spawnFailed == true)
//        {
//            ToggleUI(cantspawnmsg.gameObject, 1);
//           // toggleTimer();
//            ToggleUI(cantspawnmsg.gameObject, 0);
//        }
//    }*/
//    /*
//    void OnTriggerStay2D(Collider2D other)
//    {
//        if (other.gameObject.tag != null && other.gameObject.tag != "Player")
//        {
//            cantspawnmsg.gameObject.SetActive(true);
//        }
//    }

//    void OnTriggerExit2D(Collider2D other)
//    {
//       cantspawnmsg.gameObject.SetActive(false);
    
//    }

//    private void OnTriggerEnter2D(Collider2D collision)
//    {

//        Debug.Log("Called" + collision);
//        if (collision.gameObject.tag != null && collision.gameObject.tag != "Player")
//        {
//            cantspawnmsg.gameObject.SetActive(true);

//            spawnbot.canIspawn = false;
            
//            Debug.Log("Cant spawn here");
//        }
//        else
//        {
//            //ToggleUI(cantspawnmsg.gameObject, 0);

//            spawnbot.canIspawn = true;
//        }
//    }*/
    
//    /// <summary>
//    /// Switches UI active state. Pass the element as "NameofUi".gameObject, and either 0 for false, and 1 for true
//    /// </summary>
//    GameObject ToggleUI(GameObject toggleMe, int id)
//    {
//        if (id == 1)
//        {
//            toggleMe.gameObject.SetActive(true);
//        }
//        if (id == 0)
//        {
//            toggleMe.gameObject.SetActive(false);
//        }

//        return toggleMe;

//    }
//    private void FixedUpdate()
//    {
//        Vector2 forward = transform.TransformDirection(Vector2.right) * MaxRayDist;
//        Ray ray = new Ray(transform.position, Vector2.right);
//      //  Vector2 raycst  = new Vector2(this.transform.position.x, this.transform.position.y - 0.2F);
//        Debug.DrawRay(transform.position, forward, Color.red);
//        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, MaxRayDist);

//        CheckWall(hit);
  
        
//        //if (hit.collider.tag != null)
//        //{
//            //Debug.Log("I hit " + hit.collider.tag);
//        // }

//        Vector2 backwards = transform.TransformDirection(Vector2.left) * MaxRayDist;
//        Ray rey = new Ray(transform.position, Vector2.left);

//        Debug.DrawRay(transform.position, backwards, Color.red);
//        RaycastHit2D hitt = Physics2D.Raycast(transform.position, Vector2.left, MaxRayDist);

        
//        CheckWall(hitt);

//    }

//    void CheckWall(RaycastHit2D hit)
//    {
//        if (hit.collider == null)
//        {
//            //ToggleUI(cantspawnmsg.gameObject, 0);

//            spawnbot.canIspawn = true;
//        }
//        else
//        {
//            //cantspawnmsg.gameObject.SetActive(true);
//            spawnbot.canIspawn = false;
//            Debug.Log(hit.collider.tag);
//            Debug.Log("is it? " + spawnbot.canIspawn);
//            Debug.Log("Cant spawn here");
//        }

//        //if ( hit.collider.tag != "Player")
//        //{

//        //    cantspawnmsg.gameObject.SetActive(true);
//        //    spawnbot.canIspawn = false;

//        //    Debug.Log("Cant spawn here");
//        //}
//        //else
//        //{
//        //    ToggleUI(cantspawnmsg.gameObject, 0);

//        //    spawnbot.canIspawn = true;
//        //}
//    }
      


//    /*
//        IEnumerator toggleTimer()
//        {

//                ToggleUI(cantspawnmsg.gameObject, 1);

//                yield return new WaitForSeconds(3);

//                 ToggleUI(cantspawnmsg.gameObject, 0);

//        }*/
//}
