using UnityEngine;
using System.Collections;
using System.IO;
using System;
using System.Collections.Generic;

public class DataParser : MonoBehaviour {

	float incl, Au, M, X, H, G, Peri, node, ecc, meanA;
	int desn;
	private float Theta = 0;
	private motion OBJ;
	private Asteroid OBJ2;
	//rivate int indexTolimit = 0;
	public int maxLimit = 1000;
	public int lowerB = 10;


	public Transform prefab;

	public StreamReader dataFile;
	public string currentLine, epoch;

	public void jumpToData()
	{
		for(var i = 0; i <= lowerB; i++)
		{
			currentLine = dataFile.ReadLine ();
		}
	}
	
	/**
	 * Description: On begining of program, open data file and set start parsing with string arrays.
	 */
	void Start (){

		dataFile = new StreamReader ("largeData2.txt");
		jumpToData();

		/*for(int i = 0; i <500; i++){

		if(currentLine != null){
			
			string[] tokens = currentLine.Split (new Char[] {' ', '\n'}, StringSplitOptions.RemoveEmptyEntries);
			
			OBJ = prefab.GetComponent<motion>();
			
			incl = Convert.ToSingle(tokens[7]);
			Au = Convert.ToSingle(tokens[10]);
			M =  Convert.ToSingle(tokens[4]);
			Theta = Convert.ToSingle(tokens[9]);
			
			float inclf = (float)(Au*Mathf.Sin(incl));
			X =(float)(Au*Mathf.Sin(M));
			
			
			
			Instantiate(prefab, new Vector3(Au*3000, X*100, inclf*100), Quaternion.identity); //call to populate.
			
			
			OBJ2 = prefab.GetComponent<Asteroid>();
			OBJ2.setName(tokens[22]);
			OBJ2.setDistance(Convert.ToSingle(tokens[10]));
			OBJ2.setEccentric(Convert.ToSingle (tokens[8]));
			OBJ2.setIncline(Convert.ToSingle (tokens[7]));
			
			Debug.Log (OBJ2.getName());
			OBJ.setAngle(Theta); //Set motion speed based on degrees per frame.
			
			currentLine = dataFile.ReadLine();
			}
		}*/

	}
		
	// Update is called once per frame
	/**
	 * Descripton: Reads through data file during run-time. Each frame 5 additional objects are created.
	 */
	void Update () {
	

		if( lowerB < 100000){

			lowerB++;

			for(int i= 0; i < 5; i++){
				if(currentLine != null){

					string[] tokens = currentLine.Split (new Char[] {' ', '\n'}, StringSplitOptions.RemoveEmptyEntries);

					OBJ = prefab.GetComponent<motion>();

					incl = Convert.ToSingle(tokens[7]);
					Au = Convert.ToSingle(tokens[10]);
					M =  Convert.ToSingle(tokens[4]);
					Theta = Convert.ToSingle(tokens[9]);
			
					float inclf = (float)(Au*Mathf.Sin(incl));
					X =(float)(Au*Mathf.Sin(M));
			


					Instantiate(prefab, new Vector3(Au*3000, X*100, inclf*100), Quaternion.identity); //call to populate.


					OBJ2 = prefab.GetComponent<Asteroid>();
					OBJ2.setName(tokens[22]);
					OBJ2.setDistance(Convert.ToSingle(tokens[10]));
					OBJ2.setEccentric(Convert.ToSingle (tokens[8]));
					OBJ2.setIncline(Convert.ToSingle (tokens[7]));
			
				Debug.Log (OBJ2.getName());
					OBJ.setAngle(Theta); //Set motion speed based on degrees per frame.

					currentLine = dataFile.ReadLine();
				}

		
			}
		}
	}
	
}
