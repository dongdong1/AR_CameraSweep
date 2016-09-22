using UnityEngine;
using System.Collections;

public class HP : MonoBehaviour {

	public static double hpvalue=100;
	public Texture t;
	public Texture gameover;
	public float score = 0.0F;
	public float totaltime = 60F;
	public int count = 0;
	public AudioClip clip;
    

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		hpvalue = (totaltime - Time.time) / totaltime * 100;
		if (hpvalue < 0)
			hpvalue = 0;
		Debug.Log (hpvalue);
	}

	void OnGUI()
	{

        Texture2D mycoin = Resources.Load("flag/coin") as Texture2D;

        if (HP.hpvalue <= 0 || score == 500F) {
			GameObject.Find ("ARCamera").GetComponent<AudioSource> ().Stop ();
			//GameObject.Find ("ARCamera").GetComponent<AudioSource> ().PlayOneShot (clip);
			//end of game
			Rect r1 = new Rect (0, 0, Screen.width, Screen.height);
			GUI.DrawTexture (r1, gameover);
			//GetComponent<AudioSource> ().Stop ();
			string s = "";
			if (score == 500F)
				s = "Congrats! You caught 'em all!";
			else if (score >= 300F && score < 500F) {
				s = "Good job!";
			} else {
				s = "More treasure awaits...";
			}
			GUI.Label (new Rect(Screen.width*(1.8F/5F),Screen.height*(0.8F/2.0F),Screen.width*(6.0F/10.0F),Screen.height*(2.0F/20.0F)),"<size=50>"+s+"</size>");
			GUI.Label (new Rect(Screen.width*(1.8F/5F),Screen.height*(1.4F/2.0F),Screen.width*(4.0F/10.0F),Screen.height*(2.0F/20.0F)),"<size=40>Thank you for playing!</size>");
		

		} else {
            //GUI overlay during game
            GUI.DrawTexture(new Rect(Screen.width * (3.6F / 5F), Screen.height * (2.4F / 80.0F), Screen.width * (1.5F / 20.0F), Screen.height * (0.75F / 20.0F)), mycoin);
            GUI.contentColor = Color.white;
			Rect r = new Rect (40, 10, (int)hpvalue * (0.7F*Screen.width/100F), 10);
			GUI.DrawTexture (r,t);
			string s = " X"+score;
			GUI.Label (new Rect(Screen.width*(4F/5F),Screen.height*(1.0F/80.0F),Screen.width*(1.8F/20.0F),Screen.height*(1.8F/20.0F)),"<size=41>"+s+"</size>");
			GUI.Label (new Rect(Screen.width*(2F/5F),Screen.height*(1.0F/80.0F+1.2F/20.0F),Screen.width*(4.0F/10.0F),Screen.height*(1.0F/20.0F)),"<size=37>"+"Remaining Treasure: "+(5-count)+"</size>");
		}

	}


}
