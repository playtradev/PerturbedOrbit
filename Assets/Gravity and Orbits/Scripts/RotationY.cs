using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationY : MonoBehaviour {

	// Use this for initialization

	//use this for rotating speed
	public float rotatingSpeed=0.5f;
	float elapsed;
	Rigidbody rb;

	void Start () {
		elapsed = 0;
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{

		elapsed += Time.fixedDeltaTime;

		rb.rotation = Quaternion.Euler(0, elapsed * rotatingSpeed,0);


	}
}
