using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class bck : MonoBehaviour
{
    public RectTransform mainMenu, scene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Space))
        {
            scene.DOAnchorPos(new Vector2(1111, 0), 0.25f);
            mainMenu.DOAnchorPos(new Vector2(0, 0), 0.25f);
            
        }
    }
}
