using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialSpeed : MonoBehaviour {

	// Use this for initialization
	//this is the speed value and direction
	public float speed;
	public Vector3 direction;

	void Start () 
	{
		gameObject.GetComponent<Rigidbody> ().velocity = speed * direction;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
