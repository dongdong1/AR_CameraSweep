using UnityEngine;
using System.Collections;

public class enemyHP : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GameObject.Find ("First Person Controller").GetComponent<HP> ().score += 100;
	}
}
