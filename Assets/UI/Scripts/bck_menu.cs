using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bck_menu : MonoBehaviour
{
    public GameObject db;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Space))
        {
            db.SetActive(false);
        }
    }
}
