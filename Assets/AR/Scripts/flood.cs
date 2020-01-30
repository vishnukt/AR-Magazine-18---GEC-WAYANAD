using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class flood : MonoBehaviour
{
    string btnName;

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
                if (btnName == "flood_donation")
                {
                    link();
                }
            }
        }
    }
    public void link()
    {
        Application.OpenURL("https://donation.cmdrf.kerala.gov.in/");
    }
}
