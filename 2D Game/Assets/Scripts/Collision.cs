using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update (Collider col) {
		if(col.name == "Particle System")
		{
			Score.pointVal += 1;
			// It is object tagged with TagB
		}
	}
d
}
