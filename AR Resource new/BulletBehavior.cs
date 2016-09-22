using UnityEngine;
using System.Collections;

public class BulletBehavior : MonoBehaviour {

	public AudioClip cliphit;

	// Use this for initialization
	void Start () {
		//Rigidbody t = GetComponent<Rigidbody> ();
		//t.velocity = new Vector3 (0, 0, 1F);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider x){
		/*
		if (x.name == "Sea") {
			transform.position = checkp.transform.position;
			if (HP.hpvalue >= 30)
				HP.hpvalue -= 30;
			else
				HP.hpvalue = 0;
		}

		
		if (x.name == "Transport1") {
			transform.position = top1.transform.position;
		}
		*/

		if (x.name != "First Person Controller") {

			if (x.name == "pig" || x.name == "enemy_pig(Clone)") {
				x.GetComponent<enemyHP>().HP -= 400;
				GameObject.Find ("First Person Controller").GetComponent<AudioSource> ().PlayOneShot (cliphit);
			}

			Destroy (this.gameObject);
		}
	}



}
