﻿using UnityEngine;
using System.Collections;

public class AutoRotate : MonoBehaviour {

	public float speed=1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0, 0, 0.7f * speed);
	}
}
