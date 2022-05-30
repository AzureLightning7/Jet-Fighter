using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompassControl : MonoBehaviour {

    public GameObject ground;

	void Start()
    {
		
	}
	
	void Update()
    {
        // get the ground rotation to always point that way
        this.transform.rotation = ground.transform.rotation;
        // rotate * 90 because the compass is also rotated
        this.transform.Rotate(Vector3.right * 90);
	}
}
