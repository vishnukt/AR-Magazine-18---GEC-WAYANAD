using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitscript : MonoBehaviour
{
    public string scenename;
    public void exit()
    {
        Application.LoadLevel(scenename);
    }
}
