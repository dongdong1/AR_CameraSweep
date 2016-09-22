using UnityEngine;
using System.Collections;

public class HP : MonoBehaviour {

	public static double hpvalue=100;
	public Texture t;
	public Texture gameover;
	public float score = 0.0F;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnGUI()
	{
		GUI.contentColor = Color.green;
		Rect r = new Rect (40, 10, (int)hpvalue * (0.7F*Screen.width/100F), 10);
		GUI.DrawTexture (r,t);

		if (HP.hpvalue <= 0) {
			Rect r1 = new Rect (0, 0, Screen.width, Screen.height);
			GUI.DrawTexture (r1,gameover);
			GetComponent<AudioSource> ().Stop ();
		}

		GUI.Label (new Rect(Screen.width*(4F/5F),Screen.height*(1.0F/80.0F),Screen.width*(1.0F/10.0F),Screen.height*(1.0F/20.0F)),"Score:" + score);
	}


}
