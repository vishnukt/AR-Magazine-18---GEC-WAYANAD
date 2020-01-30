using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class info : MonoBehaviour
{
    public GameObject info_panel;
    // Start is called before the first frame update
    public void infobutton()
    {
        info_panel.SetActive(true);
        StartCoroutine(QuitingTimer());
    }
    IEnumerator QuitingTimer()
    {
        yield return new WaitForSeconds(5);
        info_panel.SetActive(false);
    }
    public void info_disable()
    {
        info_panel.SetActive(false);
    }
}
