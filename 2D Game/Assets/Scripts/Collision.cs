using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Collision : MonoBehaviour
{
	public GameObject good;
	public GameObject bad;
	
	
	public AudioSource bottle;
	public AudioSource paper;
	
	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update () {	
	}
	
	//void OnCollisionEnter2D(Collision2D col)
	//{
	//	if(col.gameObject.name.Equals("Bottles"))
	//	{
	//		PointScript.pointVal += 1;
	//	}
	//}
	
	public void OnParticleCollision(GameObject other)
	{
		
		if (other == good)
		{
			paper.Play();
			PointScript.pointVal += 1;
		}
		
		if (other == bad)
		{
			bottle.Play();
			PointScript.pointVal -= 1;
		}
	}
}
