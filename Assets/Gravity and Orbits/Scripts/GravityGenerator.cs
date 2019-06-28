using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityGenerator : MonoBehaviour {

	// Use this for initialization
	// these are the objects that generate the gravity field
	public Rigidbody[] generators;
	//these are the objects that are affected by the gravity
	public Rigidbody[] affected;
	//this is the G factor
	public float Gfactor=0.1f;
	//the forces;
	public Vector3[] forces;

	void Start () 
	{		
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{

		// for each of the generators we create a force
		for (int ii=0; ii<generators.Length;ii++)
		{
			// for each of the affected objects
			for (int jj=0; jj<affected.Length;jj++)
			{
				//check that is not the same object
				if(generators[ii].name!=affected[jj].name)
				{
					

					//we obtain the force value and it vector
					float distance= (generators[ii].position-affected[jj].position).magnitude;
					Vector3 directionForce=(generators[ii].position-affected[jj].position)/distance;
					float forceValue=(generators[ii].mass*affected[jj].mass)/Mathf.Pow(distance,2);

					Debug.Log("Force "+generators[ii].name+"-->"+affected[jj].name+"  value = "+forceValue);

					/*debug values for checking the force
					Debug.Log (distance);
					Debug.Log (directionForce);
					Debug.Log (forceValue);
					*/
					forces [jj] += Gfactor * forceValue * directionForce;

				}
			}
		}

		// apply force
		for (int jj = 0; jj < affected.Length; jj++) 
		{
			affected [jj].AddForce (forces [jj]);

			//reset force
			forces [jj] = new Vector3 ();
		}
	}
}
