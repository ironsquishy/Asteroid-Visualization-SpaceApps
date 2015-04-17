using UnityEngine;
using System.Collections;

public class PlanetaryNavigation : MonoBehaviour { 
	/* Example level loader */

	GUIStyle planetaryGUI;

	Texture2D arrow;
	Texture2D arrow2;
	Texture2D twoD;
	Texture2D threeD;
	Texture2D plus;
	Texture2D minus;
	Texture2D reset;
	


	void Start() {

		camSwap (1);

		planetaryGUI = new GUIStyle();
		
		planetaryGUI.fontSize = 10;

		arrow = Resources.Load("arrow") as Texture2D;
		arrow2 = Resources.Load("arrow2") as Texture2D; 
		twoD = Resources.Load("2d") as Texture2D;
		threeD = Resources.Load("3d") as Texture2D;
		plus = Resources.Load("plus") as Texture2D;
		minus = Resources.Load("minus") as Texture2D;
		reset = Resources.Load("reset") as Texture2D;


	}

	void camSwap(int currentCam){
		GameObject[] cameras = GameObject.FindGameObjectsWithTag("MainCamera");
		
		foreach (GameObject cams in cameras){
			Camera theCam = cams.GetComponent<Camera>() as Camera;
			theCam.enabled = false;
		}  
		
		string oneToUse = "Camera"+currentCam;
		Camera usedCam = GameObject.Find(oneToUse).GetComponent<Camera>() as Camera;
		usedCam.enabled = true;
	}

	void Update (){
		if (Input.GetKeyDown ("up") && Camera.main.transform.position.z < 90000) {
			Camera.main.transform.Translate(new Vector3(0,1000,0));
		}
		if (Input.GetKeyDown ("down") && Camera.main.transform.position.z > -90000) {
			Camera.main.transform.Translate(new Vector3(0,-1000,0));
		}
		if (Input.GetKeyDown ("left")&& Camera.main.transform.position.x > -90000) {
			Camera.main.transform.Translate(new Vector3(-500,0,0));
		}

		if (Input.GetKeyDown ("right")&& Camera.main.transform.position.x < 90000) {
			Camera.main.transform.Translate(new Vector3(500,0,0));
		}
	}


	void OnGUI () {

		// Make a background box
		GUI.Box(new Rect(10,10,100,25), "Planetary Nav");
		if(GUI.Button(new Rect(110,10,30,30), arrow)) {
			if (Camera.main.transform.position.z > -3000){
				Camera.main.transform.Translate(new Vector3(0,-300,0));
			}
			if (Camera.main.transform.position.z < -90000){
				Camera.main.transform.Translate(new Vector3(0,0,0));
			}

			else if (Camera.main.transform.position.z < -3000){
				Camera.main.transform.Translate(new Vector3(0,-2000,0));
			}
		
		}

		if(GUI.Button(new Rect(140,10,30,30), arrow2)) {
			if (Camera.main.transform.position.z < -3000){
			Camera.main.transform.Translate(new Vector3(0,2000,0));
			}
			if (Camera.main.transform.position.z > 0){
				Camera.main.transform.Translate(new Vector3(0,0,0));
			}
			else if (Camera.main.transform.position.z > -3000){
				Camera.main.transform.Translate(new Vector3(0,300,0));
			}
		}

		if(GUI.Button(new Rect(170,10,30,30), plus)) {

			if (Camera.main.transform.position.y < 6100 && Camera.main.transform.position.y > 2300){
			Camera.main.transform.Translate(new Vector3(0,0,100));
			}

			if (Camera.main.transform.position.y < 31000 && Camera.main.transform.position.y > 6100){
				Camera.main.transform.Translate(new Vector3(0,0,1000));
			}

		}

		if(GUI.Button(new Rect(200,10,30,30), minus)) {

			if (Camera.main.transform.position.y > 2000 && Camera.main.transform.position.y < 6000){
				Camera.main.transform.Translate(new Vector3(0,0,-100));
			}

			if (Camera.main.transform.position.y > 6000 && Camera.main.transform.position.y < 30000){
				Camera.main.transform.Translate(new Vector3(0,0,-1000));
			}
		}

		if(GUI.Button(new Rect(230,10,30,30), reset)) {
			Camera.main.transform.position = new Vector3(156,5594,-2195);



			GameObject parseBigD = GameObject.Find("parseBIGD");
			parseBigD.SetActive(false);

			GameObject destroyer = GameObject.Find("destroyer");
			destroyer.GetComponent<destroyObjects>().enabled = true;
		} 

		//Mercury 

		if(GUI.Button(new Rect(110,45,30,30), twoD)) {
			camSwap(1);
		}
		
		if(GUI.Button(new Rect(140,45,30,30), threeD)) {
			camSwap (2);
			
		}

		//Venus

		if(GUI.Button(new Rect(110,75,30,30), twoD)) {
			camSwap(1);
			
		}
		
		if(GUI.Button(new Rect(140,75,30,30), threeD)) {
			camSwap(3);
			
		}

		//Earth

		if(GUI.Button(new Rect(110,105,30,30), twoD)) {
			camSwap (1);
			
		}
		
		if(GUI.Button(new Rect(140,105,30,30), threeD)) {
			camSwap(4);
			
		}

		//Mars

		if(GUI.Button(new Rect(110,135,30,30), twoD)) {
			camSwap(1);
			
		}
		
		if(GUI.Button(new Rect(140,135,30,30), threeD)) {
			camSwap(5);
			
		}

		//Jupiter

		if(GUI.Button(new Rect(110,165,30,30), twoD)) {
			camSwap(1);
			
		}
		
		if(GUI.Button(new Rect(140,165,30,30), threeD)) {
			camSwap(6);
			
		}

		//Saturn

		if(GUI.Button(new Rect(110,195,30,30), twoD)) {
			camSwap(1);
			
		}
		
		if(GUI.Button(new Rect(140,195,30,30), threeD)) {
			camSwap(7);
			
		}

		//Uranus

		if(GUI.Button(new Rect(110,225,30,30), twoD)) {
			camSwap(1);
			
		}
		
		if(GUI.Button(new Rect(140,225,30,30), threeD)) {
			camSwap(8);
			
		}

		//Neptune

		if(GUI.Button(new Rect(110,255,30,30), twoD)) {
			
			camSwap(1);
		}
		
		if(GUI.Button(new Rect(140,255,30,30), threeD)) {
			camSwap(9);
			
		}



		GUI.Box(new Rect(15,35,60,300), "\nMercury \n\n Venus \n\n Earth \n\n Mars \n\n Jupiter \n\n Saturn \n\n Uranus \n\n Neptune");

		
		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		
		
		// Make the second button.
		//if(GUI.Button(new Rect(20,70,80,20), "Level 2")) {
		//	Application.LoadLevel(2);
		}
	}

