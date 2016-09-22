using UnityEngine;
using System.Collections;

public class ShootBullet : MonoBehaviour {

	public Transform shotSpawn;
	private float fireRate=0.25F;
	private float nextFire=0.0F;
	private float bulletSpeed=100F;
	public GameObject projectile;
	private AudioSource audio_source;
	public AudioClip clip_shoot;
	public Texture crosshair;

	// Use this for initialization
	void Start () {
		audio_source = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {

		bool tempfire = false;
		foreach (Touch t in Input.touches) {
			Rect r = new Rect (Screen.width * (3.5F/4.0F), Screen.height * (0.2F/3.0F), Screen.width * (1.0F / 10.0F), Screen.height * (1.0F / 10.0F));
			if(r.Contains(t.position) /*&& t.phase == TouchPhase.Began*/){
				tempfire = true;
			}
		}

		if (tempfire && Time.time > nextFire) {
			Fire ();
		}
	}

	void OnGUI () {

		float x = Screen.width * (1F / 2F);
		float y = Screen.height * (1F / 2F);
		float a = Screen.width * (1.0F / 50.0F);
		Rect r_center = new Rect(x-0.5F*a,y-0.5F*a,a,a);
		GUI.DrawTexture (r_center, crosshair);

		GUI.Button(new Rect(Screen.width*(3.5F/4.0F),Screen.height*(2.8F/3.0F-1.0F/10.0F),Screen.width*(1.0F/10.0F),Screen.height*(1.0F/10.0F)), "Fire");	
	}

	void Fire() {
		nextFire = Time.time + fireRate;
		audio_source.PlayOneShot (clip_shoot);
		GameObject clone = (GameObject) Instantiate (projectile, shotSpawn.position, shotSpawn.rotation);
		clone.GetComponent<Rigidbody>().velocity = shotSpawn.forward * bulletSpeed;
		Debug.Log ("Fire! "+Time.time+" nextfire=" + nextFire);
	}

}
