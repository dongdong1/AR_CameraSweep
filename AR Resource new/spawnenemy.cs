using UnityEngine;
using System.Collections;

public class spawnenemy : MonoBehaviour {

	private float nextSpawn = 0.0F;
	private float spawnRate = 10F;
	private float spawnRadius = 120F;

	public GameObject enemy;
	public GameObject target;

	// Use this for initialization
	void Start () {
		target = GameObject.Find("First Person Controller");
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Time.time > nextSpawn)
			Spawn ();

	}

	void Spawn(){
		nextSpawn = Time.time + spawnRate;

		Vector3 spawnPosition = new Vector3(0F,0F,0F);
		Vector2 randomVector;

		randomVector = Random.insideUnitCircle * spawnRadius;
		spawnPosition.x = randomVector.x;
		spawnPosition.z = randomVector.y;
		spawnPosition += transform.position;

		GameObject enemyclone = (GameObject) Instantiate (enemy, spawnPosition, new Quaternion(0F,0F,0F,0F));

		enemyclone.GetComponent<Chase>().target = target;
		enemyclone.GetComponent<SmoothLookAt_enemy>().target = target.GetComponent<Transform> ();
	}
}
