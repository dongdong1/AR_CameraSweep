using UnityEngine;
using System.Collections;

public class increaseScore : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GameObject.Find ("ARCamera").GetComponent<HP> ().score += 100;
	}
}
