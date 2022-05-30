using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPointerControl : MonoBehaviour {

    public GameObject enemy; // enemy building

    void Start()
    {
		
	}
	
	void Update()
    {
        this.transform.LookAt(enemy.transform);  // point at building
        this.transform.Rotate(Vector3.right * 90);// rotate pointer
	}
}
