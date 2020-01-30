using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UI : MonoBehaviour
{
    public RectTransform mainMenu, editorial, about, download;
    public GameObject db;
    // Start is called before the first frame update
    void Start()
    {
        mainMenu.DOAnchorPos(Vector2.zero, 0.25f);
    }

    public void EditorialButton()
    {
        mainMenu.DOAnchorPos(new Vector2(1111, 0), 0.25f);
        editorial.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }
    /*public void EditorialBack()
    {
        mainMenu.DOAnchorPos(new Vector2(0, 0), 0.25f);
        editorial.DOAnchorPos(new Vector2(1111, 0), 0.25f);
    }*/

    public void AboutButton()
    {
        mainMenu.DOAnchorPos(new Vector2(1111, 0), 0.25f);
        about.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void DownloadButton()
    {
        mainMenu.DOAnchorPos(new Vector2(1111, 0), 0.25f);
        download.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void exit()
    {
        Application.Quit();
    }
    public void menu()
    {
        db.SetActive(true);
    }
    public void menu_disable()
    {
        db.SetActive(false);
    }
}
