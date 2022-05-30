using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    public GameObject rocket;
    public Transform source;

    // Variables added for crashing
    public GameObject explosion;  // Boom!
    private float speed;          // Jet speed
    private Rigidbody rb;

	void Start()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	void Update()
    {
		if (Input.GetButtonDown("Fire2"))
        {
            var myProjectile = Instantiate(rocket, source.position, source.rotation);
        }

        if (Input.GetButtonDown("Fire1"))
        {
            
        }
	}

    private void FixedUpdate()
    {
        speed = rb.velocity.magnitude;  // get the jet speed for crash check
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (speed > 100)    //if flying fast, not on takeoff
        {
            Instantiate(explosion, transform);
            rb.velocity = new Vector3();
            rb.isKinematic = true;
            Invoke("Respawn", 3.0f);    // Pause for dramatic effect
        }
    }

    private void Respawn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
