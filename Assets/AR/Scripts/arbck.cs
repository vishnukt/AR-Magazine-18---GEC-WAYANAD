﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arbck : MonoBehaviour
{
    /*public string scenename;
    public void back()
    {
        Application.LoadLevel(scenename);
    }*/
    public void exit()
    {
        Application.Quit();
    }
   
    /*// Start is called before the first frame update
    void Start()
    {
        
    }*/

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Space))
        {
            exit();
        }
    }
    
}
