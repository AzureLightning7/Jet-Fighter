using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketControl : MonoBehaviour {

    Rigidbody rb;
    public float speed = 500;

    public GameObject explosion; // what to spawn on collision
    public float explodeLifetime; // how long to explode in seconds

	void Start()
    {
        rb = GetComponent<Rigidbody>();
        Destroy(gameObject, 5); // destroy in 5 seconds
        rb.velocity = transform.forward * speed;
	}
	
    private void OnCollisionEnter( Collision collision)
    {
        GameObject myExplode = Instantiate(explosion, transform.position, Quaternion.identity);
        //remove the explosion
        Destroy(myExplode, explodeLifetime);
        Destroy(gameObject);
    }
}