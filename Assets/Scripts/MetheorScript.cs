﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetheorScript : MonoBehaviour
{

	public Rigidbody RB;
    // Start is called before the first frame update
    void Start()
    {
		RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
		if(Input.GetMouseButtonUp(0))
		{
			RB.AddForce(Vector3.forward);
		}
    }
}
