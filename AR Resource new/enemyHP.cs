using UnityEngine;
using System.Collections;

public class enemyHP : MonoBehaviour {

	public float HP = 100F;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (HP <= 0F) {
			Destroy (this.gameObject);
			GameObject.Find ("First Person Controller").GetComponent<HP> ().score += 100;
		}
	}
}
