using UnityEngine;
using System.Collections;
using Vuforia;

public class uiUOFT : MonoBehaviour
{

    private DefaultTrackableEventHandler dtehUOFT;
    // Use this for initialization
    void Start()
    {
        dtehUOFT = GetComponent<DefaultTrackableEventHandler>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnGUI()
    {
        Texture2D mypic2 = Resources.Load("flag/uoft") as Texture2D;

        if (mypic2 != null)
        {
            if (dtehUOFT.tracked == false)
            {
                GUI.DrawTexture(new Rect(Screen.width * (1F / 5F), Screen.height * (1.7F / 2.0F), Screen.width * (1.5F / 10.0F), Screen.height * (0.65F / 10.0F)), mypic2);
            }
        }

        /*GUIStyle myStyle = new GUIStyle(GUI.skin.button);
        myStyle.fontSize = 70;

        myStyle.normal.textColor = Color.red;
        myStyle.hover.textColor = Color.blue;

        if (dtehUOFT.ui_enable == true)
        {

            if (GUI.Button(new Rect(640, 1200, 400, 200), "Link to", myStyle))
            {
                Application.OpenURL("https://unity3d.com/cn");
            }
        }
        else
        {
            GUI.enabled = false;
        }*/

    }
}
