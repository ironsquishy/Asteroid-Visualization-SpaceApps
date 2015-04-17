using UnityEngine;
using System.Collections;

public class JupiterOrbit : MonoBehaviour {
	
	//private float degreeOfRotation = 0.0f;
	// Use this for initialization
	//void Start () {

		//InvokeRepeating("degreeCounter",0,1);
	
	//}
	
	// Update is called once per frame
	void Update () {
	 
		//if (degreeOfRotation < 1 && degreeOfRotation > 0.7){Debug.Log ("Start Time: " + Time.time);}
		//else if (degreeOfRotation >= 5.8 && degreeOfRotation < 6.8) {
			//Debug.Log ("End Time: " + Time.time);
			//degreeOfRotation = 0;
		//}

		transform.RotateAround (Vector3.zero, Vector3.down, 0.90f * Time.deltaTime);

	}

	//void degreeCounter () {
		//degreeOfRotation += 0.90f;
		//Debug.Log (degreeOfRotation);
	//}
}
