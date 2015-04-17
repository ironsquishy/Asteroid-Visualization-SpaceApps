using UnityEngine;
using System.Collections;

public class destroyObjects : MonoBehaviour {

	GameObject[] gameObjects = GameObject.FindGameObjectsWithTag ("asteroid");

	public void DestroyAllObjects()
	{

		for(var i = 0 ; i < gameObjects.Length; i ++)
		{
			Destroy(gameObjects[i]);
		}
	}
	// Use this for initialization
	void Start () {

		GameObject destroyer = GameObject.Find("parseBIGD");
		destroyer.GetComponent<DataParser>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

		DestroyAllObjects ();
	}
}
