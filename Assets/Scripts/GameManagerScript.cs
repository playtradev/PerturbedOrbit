﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{

	public static GameManagerScript Instance;

	public List<AttractionScript> Attractors = new List<AttractionScript>();

	private void Awake()
	{
		Instance = this;
	}

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
