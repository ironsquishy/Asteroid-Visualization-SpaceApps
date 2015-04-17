using UnityEngine;
using System.Collections;

public class VenusOrbit : MonoBehaviour {
	
	//private float degreeOfRotation = 0.0f;
	 //Use this for initialization
	//void Start () {

		//InvokeRepeating("degreeCounter",0,1);
	
	//}
	
	// Update is called once per frame 
	void Update () {
	 
		//if (degreeOfRotation < 17 && degreeOfRotation > 14){Debug.Log ("Start Time: " + Time.time);}
		//else if (degreeOfRotation >= 340 && degreeOfRotation < 380) {
			//Debug.Log ("End Time: " + Time.time);
			//degreeOfRotation = 0;
		//}

		transform.RotateAround (Vector3.zero, Vector3.down, 16.0f * Time.deltaTime);

	}

	//void degreeCounter () {
	//	degreeOfRotation += 16.0f;
	//	Debug.Log (degreeOfRotation);
	//}
}
