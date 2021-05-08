using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HyperLink : MonoBehaviour
{
    public void OpenGmailLink()
    {
        Application.OpenURL ("mailto:alex.wills.nz@gmail.com");
    }

    public void OpenLinkedinLink()
    {
        Application.OpenURL("https://www.linkedin.com/in/alex-wills-2184a115b/");
    }

    public void callPhone()
    {
        Application.OpenURL("tel://0278418971");
    }

    public void uiVideo()
    {
        Application.OpenURL("https://youtu.be/h-GEU3_8uLM");
    }

    public void trailerVideo()
    {
        Application.OpenURL("https://youtu.be/S9bIcWhdwWg");
    }
}
