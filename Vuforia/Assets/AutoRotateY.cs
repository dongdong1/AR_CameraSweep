using UnityEngine;
using System.Collections;

public class AutoRotateY : MonoBehaviour {

	public float speed = 1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0, 0.7f * speed, 0);
	}
}
