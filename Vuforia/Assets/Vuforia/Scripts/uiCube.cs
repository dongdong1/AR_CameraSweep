using UnityEngine;
using System.Collections;
using Vuforia;

public class uiCube : MonoBehaviour {

    private DefaultTrackableEventHandler dteh;
    // Use this for initialization
    void Start () {
        dteh = GetComponent<DefaultTrackableEventHandler>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnGUI()
    {
        Texture2D mypic4 = Resources.Load("flag/cube") as Texture2D;

        if (mypic4 != null)
        {
            if (dteh.tracked == false)
            {
                GUI.DrawTexture(new Rect(Screen.width * (3F / 5F), Screen.height * (1.7F / 2.0F), Screen.width * (1.5F / 10.0F), Screen.height * (0.65F / 10.0F)), mypic4);
            }
        }

        /*GUIStyle myStyle = new GUIStyle(GUI.skin.button);
        myStyle.fontSize = 70;

        myStyle.normal.textColor = Color.red;
        myStyle.hover.textColor = Color.blue;

        if (dteh.ui_enable == true)
        {

            if (GUI.Button(new Rect(640, 1200, 400, 200), "Link to", myStyle))
            {
                Application.OpenURL("http://mobile.utoronto.ca/madlab");
            }
        }
        else
        {
            GUI.enabled = false;
        }*/

    }
}
