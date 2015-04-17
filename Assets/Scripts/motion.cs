using UnityEngine; 
using System.Collections;
using System;

public class motion : MonoBehaviour {

	public float Theta;

	public void setAngle(float angle)
	{
		Theta  = angle;
	}

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {

		transform.RotateAround(Vector3.zero, Vector3.down, (Theta*100f)* Time.deltaTime);//speed of object.
	}
}
