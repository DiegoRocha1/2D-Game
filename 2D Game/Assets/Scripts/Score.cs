﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
	public static int pointVal = 0;
	private Text points;
	
	// Use this for initialization
	void Start ()
	{
		points = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		points.text = "Points " + pointVal;
	}
}
