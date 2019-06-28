using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttractionScript : MonoBehaviour
{

	public Rigidbody RB;
	public StarPlanetType PSType; 
	const float G = 6.674f;
	//5
	public float speed;
	//1,0,0
	public Vector3 direction;
	[Range(0, 360)]
	public float rotatingSpeed = 0.5f;
	float elapsed;

	private void Awake()
	{
		RB = GetComponent<Rigidbody>();
	}
	// Start is called before the first frame update
	void Start()
	{
		GameManagerScript.Instance.Attractors.Add(this);
		RB.velocity = speed * direction;
	}



	// Update is called once per frame
	void FixedUpdate()
	{
		foreach (AttractionScript item in GameManagerScript.Instance.Attractors)
		{
			if (item == this || item.name == "Sun")
				continue;
			Attract(item);
		}

		elapsed += Time.fixedDeltaTime;

		RB.rotation = Quaternion.Euler(0, elapsed * rotatingSpeed, 0);
	}


	void Attract(AttractionScript objectToAttrack)
	{
		if(PSType != StarPlanetType.Planet)
		{
			Rigidbody rbToAttract = objectToAttrack.RB;

            Vector3 direction = RB.position - rbToAttract.position;
            float distance = direction.magnitude;

            float forceMagnitude = G * (RB.mass * rbToAttract.mass) / Mathf.Pow(distance, 2);
            Vector3 force = direction.normalized * forceMagnitude;

            rbToAttract.AddForce(force);
		}
	}
}



public enum StarPlanetType
{
	Planet,
    Star,
    Metheor
}