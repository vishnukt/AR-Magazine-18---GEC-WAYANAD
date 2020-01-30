using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Snap : MonoBehaviour
{
    int flag = 0;
    string btnName;
    public GameObject gaunlet;
    public VideoPlayer thanos;

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if (Physics.Raycast(ray, out Hit))
            {
                btnName = Hit.transform.name;
                if (btnName == "gaunlet")
                {
                    flag = 1;
                    play();
                }
            }
        }
    }
    public void play()
    {
        if(flag == 1)
        {
            gaunlet.SetActive(false);
            thanos.Play();
        }
    }
}
