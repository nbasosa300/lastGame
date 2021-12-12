using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SourceCode : MonoBehaviour
{
    public string url = "https://github.com/nbasosa300/lastGame";

    public void loadUrl()
    {
        Application.OpenURL(url);
    }
}
