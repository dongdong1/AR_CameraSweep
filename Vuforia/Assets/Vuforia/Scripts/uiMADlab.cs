using UnityEngine;
using System.Collections;
using Vuforia;

public class uiMADlab : MonoBehaviour
{

    private DefaultTrackableEventHandler dtehmadlab;
    // Use this for initialization
    void Start()
    {
        dtehmadlab = GetComponent<DefaultTrackableEventHandler>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnGUI()
    {
        Texture2D mypic5 = Resources.Load("flag/madlab") as Texture2D;

        if (mypic5 != null)
        {
            if (dtehmadlab.tracked == false)
            {
                GUI.DrawTexture(new Rect(Screen.width * (4F / 5F), Screen.height * (1.7F / 2.0F), Screen.width * (1.5F / 10.0F), Screen.height * (0.65F / 10.0F)), mypic5);
            }
        }

        /*GUIStyle myStyle = new GUIStyle(GUI.skin.button);
        myStyle.fontSize = 70;

        myStyle.normal.textColor = Color.red;
        myStyle.hover.textColor = Color.blue;

        if (dtehmadlab.ui_enable == true)
        {

            if (GUI.Button(new Rect(640, 1200, 400, 200), "Link to", myStyle))
            {
                Application.OpenURL("http://www.vuforia.com");
            }
        }
        else
        {
            GUI.enabled = false;
        }*/

    }
}
