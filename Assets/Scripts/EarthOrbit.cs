﻿using UnityEngine;
using System.Collections;

public class EarthOrbit : MonoBehaviour {
	
	//private float degreeOfRotation = 0.0f;
	 //Use this for initialization
	//void Start () {

		//InvokeRepeating("degreeCounter",0,1);
	
	//}
	
	// Update is called once per frame 
	void Update () {
	 
		//if (degreeOfRotation == 0){Debug.Log ("Start Time: " + Time.time);}
		//else if (degreeOfRotation >= 350 && degreeOfRotation < 370) {
			//Debug.Log ("End Time: " + Time.time);
			//degreeOfRotation = 0;
		//}

		transform.RotateAround (Vector3.zero, Vector3.down, 9.5f * Time.deltaTime);

	}

	//void degreeCounter () {
		//degreeOfRotation += 9.5f;
		//Debug.Log (degreeOfRotation);
	//}
}
