using UnityEngine;
using System.Collections;
using Vuforia;

public class uiPacman : MonoBehaviour
{

    private DefaultTrackableEventHandler dtehpac;
    // Use this for initialization
    void Start()
    {
        dtehpac = GetComponent<DefaultTrackableEventHandler>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnGUI()
    {
        Texture2D mypic3 = Resources.Load("flag/library") as Texture2D;

        if (mypic3 != null)
        {
            if (dtehpac.tracked == false)
            {
                GUI.DrawTexture(new Rect(Screen.width * (2F / 5F), Screen.height * (1.7F / 2.0F), Screen.width * (1.5F / 10.0F), Screen.height * (0.65F / 10.0F)), mypic3);
            }
        }

        /*GUIStyle myStyle = new GUIStyle(GUI.skin.button);
        myStyle.fontSize = 70;

        myStyle.normal.textColor = Color.red;
        myStyle.hover.textColor = Color.blue;

        if (dtehpac.ui_enable == true)
        {

            if (GUI.Button(new Rect(640, 1200, 400, 200), "Link to", myStyle))
            {
                Application.OpenURL("https://www.utoronto.ca");
            }
        }
        else
        {
            GUI.enabled = false;
        }*/

    }
}
