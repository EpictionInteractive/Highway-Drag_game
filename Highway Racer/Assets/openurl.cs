using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openurl : MonoBehaviour
{
    public void OpenIG()
    {
        Application.OpenURL("https://instagram.com/not.gyann");
    }

    public void OpenITCH()
    {
        Application.OpenURL("https://gyann.itch.io");
    }
}

