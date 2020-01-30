using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    public GameObject cube1;

    void Update()
    {
        cube1.transform.Rotate(0,1,0);
    }
}
