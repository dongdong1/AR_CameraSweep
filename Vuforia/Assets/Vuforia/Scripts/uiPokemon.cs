using UnityEngine;
using System.Collections;
using Vuforia;

public class uiPokemon : MonoBehaviour
{

    private DefaultTrackableEventHandler dtehpokemon;
    // Use this for initialization
    void Start()
    {
        dtehpokemon = GetComponent<DefaultTrackableEventHandler>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnGUI()
    {

        Texture2D mypic1 = Resources.Load("flag/main") as Texture2D;

        if (mypic1 != null)
        {
            if (dtehpokemon.tracked == false)
            {
                GUI.DrawTexture(new Rect(Screen.width * (0.1F / 5F), Screen.height * (1.7F / 2.0F), Screen.width * (1.5F / 10.0F), Screen.height * (0.65F / 10.0F)), mypic1);

            }
        }
        /*GUIStyle myStyle = new GUIStyle(GUI.skin.button);
        myStyle.fontSize = 70;

        myStyle.normal.textColor = Color.red;
        myStyle.hover.textColor = Color.blue;

        if (dtehpokemon.ui_enable == true)
        {

                if (GUI.Button(new Rect(640, 1200, 400, 200), "Link to", myStyle))
            {
                Application.OpenURL("http://www.uefa.com/uefaeuro");
            }
        }
        else
        {
            GUI.enabled = false;
        }*/

    }
}
