using UnityEngine;
using System.Collections;

public class Oscillate : MonoBehaviour {
	public float speed =2f;
	public float startz;
	public float amplitude = 0.01f;
	// Use this for initialization
	void Start () {
		startz = transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0,0,startz+amplitude*Mathf.Sin(Time.time*speed)-transform.position.z);
	}
}
