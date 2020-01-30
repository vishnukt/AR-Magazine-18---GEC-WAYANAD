using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class back : MonoBehaviour
{
    public bool isQuiting;
    public GameObject quitMessage;
    public RectTransform panel;
    public GameObject db;
    float left;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        left = panel.offsetMin.x;
        if(isQuiting == true && left==0 && db.active==false)
        {
            if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Space))
            {
                Application.Quit();
            }
        }
        if ((Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Space))&& left==0 && db.active == false)
        {
            quitMessage.SetActive(true);
            isQuiting = true;
            StartCoroutine(QuitingTimer());
        }
    }
    IEnumerator QuitingTimer()
    {
        yield return new WaitForSeconds(2);
        isQuiting = false;
        quitMessage.SetActive(false);
    }
}
