using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour {

    private float TimeBtwShoots;
    public float startTimeBtwShots;

    public bool playerInSight = false;
    public GameObject projectile;

    public AudioClip ShootSound;
    AudioSource audioSource;

    // Use this for initialization
    void Start () {

        TimeBtwShoots = startTimeBtwShots;
        audioSource = GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	/*void Update () {

        if (playerInSight = true)
        {

            if (TimeBtwShoots <= 0)
            {
                Instantiate(projectile, transform.position, Quaternion.identity);
                TimeBtwShoots = startTimeBtwShots;
                audioSource.PlayOneShot(ShootSound);

            }
            else
            {
                TimeBtwShoots -= Time.deltaTime;

            }

        }
            
	}*/
    private void OnTriggerStay2D(Collider2D collision)
    {

        
        if (collision.tag == "Player")
        {

            if (TimeBtwShoots <= 0)
            {
                Instantiate(projectile, transform.position, Quaternion.identity);
                TimeBtwShoots = startTimeBtwShots;
                audioSource.PlayOneShot(ShootSound);

            }
            else
            {
                TimeBtwShoots -= Time.deltaTime;

            }

        }
    }


}
