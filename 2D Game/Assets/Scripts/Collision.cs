using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
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
	
	private void OnParticleCollision(GameObject other)
	{
		PointScript.pointVal += 1;
	}
}
