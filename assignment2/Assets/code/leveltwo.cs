﻿using UnityEngine;
using System.Collections;

public class leveltwo : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ( GameObject.FindGameObjectsWithTag("break").Length == 0)
		{
			Application.LoadLevel ("2.5");
		}
		if (GM.lives == 0) {
			Application.LoadLevel("gameover");
		}
	}
}
