//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//	@Author: Allen Space
//------------------------------------------------------------------------------
using UnityEngine;
using System.Collections;
using System.IO;
using System;
using System.Collections.Generic;

public class Asteroid : MonoBehaviour {
	
	private float Desn;
	private float H;
	private float G;
	private string Epoch;
	private float Mintil;
	private float peri;
	private float node;
	private float incl;
	private float ecc;
	private float MeanAnom;
	private float semimajor;
	private string title;
	
	public Asteroid()
	{
		//default constructor;
	}
	//Second Constructor to populate information about the asteroid.
	public Asteroid(int a, float b, float c, string d, float e,  float f, float g, float h, float i, float j, float dist, string name)
	{
		this.Desn = a;
		this.H = b;
		this.G = c;
		this.Epoch = d;
		this.Mintil = e;
		this.peri = f;
		this.node = g;
		this.incl = h;
		this.ecc = i;
		this.MeanAnom = j;
		this.semimajor = dist;
		this.title = name;

	}

/*------------------------------Getters below----------------------------*/

	//Ttile getter
	public string getName()
	{
		return this.title;
	}
	//Distance getter
	public float getDistance()
	{
		return this.semimajor;
	}
	
	public float getDesn()
	{
		return this.Desn;
	}
	
	public float getH()
	{
		return this.H;
	}
	
	public float getG()
	{
		return this.G;
	}
	
	public string getEpoch()
	{
		return this.Epoch;
	}
	public float getInitialMean()
	{
		return this.Mintil;
	}
	
	public float getPerihelion()
	{
		return this.peri;
	}
	
	public float getNode()
	{
		return this.node;
	}
	
	public float getInclination()
	{
		return this.incl;
	}
	
	public float getEccentric()
	{
		return this.ecc;
	}
	
	public float getMeanAnamoly()
	{
		return this.MeanAnom;
	}
	
	/*------------------------------Setters below------------------------------*/
	
	//set Name of asteroid.
	public void setName(string name)
	{
		title = name;
	}
	
	//set Distance from sun.
	public void setDistance(float AU)
	{
		this.semimajor = AU;

	}
	
	//set Des'n.
	public void setDesn(float des)
	{
		this.Desn = des;
	}
	
	//Set H.
	public void setH(float h)
	{
		this.H = h;
	}
	
	//set G.
	public void setG(float g)
	{
		this.G = g;
	}
	
	//Set Mean anamoly at Epoch or M0.
	public void setInitialMean(float m)
	{
		this.Mintil = m;
	}
	
	//Set the perihelion.
	public void setPerihelion(float p)
	{
		this.peri = p;
	}
	
	//Set node.
	public void setNode(float nod)
	{
		this.node = nod;
	}
	
	//Set inclination.
	public void setIncline(float inc)
	{
		this.incl  = inc;
	}
	
	//Set eccentricity.
	public void setEccentric(float e)
	{
		this.ecc = e;
	}
	
	//Sets mean anamoly. the rate of change per day.
	public void setMeanAnom(float m)
	{
		this.MeanAnom = m;
	}
		
}


