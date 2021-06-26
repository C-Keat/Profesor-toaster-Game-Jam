using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {
    public float speed;
    public float maxLifeTime;

    

    private Transform aim;
    private Vector2 target;



	// Use this for initialization
	void Start () {

        if (this.gameObject.tag == "Shells") { aim = GameObject.FindGameObjectWithTag("Target").transform; }
        if (this.gameObject.tag == "Shells2") { aim = GameObject.FindGameObjectWithTag("Target2").transform; }
        if (this.gameObject.tag == "Shells3") { aim = GameObject.FindGameObjectWithTag("Target3").transform; }
        

        target = new Vector2(aim.position.x, aim.position.y);
        Destroy(gameObject, maxLifeTime);
      

	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector2.MoveTowards(transform.position, target, speed *Time.deltaTime);
              	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ShieldBot"))
        {
            DestroyProjectile();
        }
    }

    void DestroyProjectile()
    {
        Destroy(gameObject);

    }
}
