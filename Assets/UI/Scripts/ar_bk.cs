using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ar_bk : MonoBehaviour
{
    public string scenename;
    public GameObject db;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Space))
        {
            if (db.active == true)
            {
                db.SetActive(false);
            }
            else
            {
                Application.LoadLevel(scenename);
            }
        }
    }
}
