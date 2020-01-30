using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.SceneManagement;
using System.IO;

public class split : MonoBehaviour
{
    private string nextScene = "loading";

    private bool obbisok = false;
    private bool loading = false;
    private bool replacefiles = false; //true if you wish to over copy each time

    private string[] paths ={
    "Vuforia/GECW_MAGAZINE18.dat",
    "Vuforia/GECW_MAGAZINE18.xml",
    "Vuforia/GECW_MAGAZINE18_2.dat",
    "Vuforia/GECW_MAGAZINE18_2.xml"
};

    void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Application.dataPath.Contains(".obb") && !obbisok)
            {
                StartCoroutine(CheckSetUp());
                obbisok = true;
            }
        }
        else
        {
            if (!loading)
            {
                StartApp();
            }
        }
    }


    public void StartApp()
    {
        loading = true;
        SceneManager.LoadScene(nextScene);
        //Application.LoadLevel(nextScene);
    }

    public IEnumerator CheckSetUp()
    {
        //Check and install!
        for (int i = 0; i < paths.Length; ++i)
        {
            yield return StartCoroutine(PullStreamingAssetFromObb(paths[i]));
        }
        yield return new WaitForSeconds(3f);
        StartApp();
    }

    //Alternatively with movie files these could be extracted on demand and destroyed or written over
    //saving device storage space, but creating a small wait time.
    public IEnumerator PullStreamingAssetFromObb(string sapath)
    {
        if (!File.Exists(Application.persistentDataPath + sapath) || replacefiles)
        {
            WWW unpackerWWW = new WWW(Application.streamingAssetsPath + "/" + sapath);
            while (!unpackerWWW.isDone)
            {
                yield return null;
            }
            if (!string.IsNullOrEmpty(unpackerWWW.error))
            {
                Debug.Log("Error unpacking:" + unpackerWWW.error + " path: " + unpackerWWW.url);

                yield break; //skip it
            }
            else
            {
                Debug.Log("Extracting " + sapath + " to Persistant Data");

                if (!Directory.Exists(Path.GetDirectoryName(Application.persistentDataPath + "/" + sapath)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(Application.persistentDataPath + "/" + sapath));
                }
                File.WriteAllBytes(Application.persistentDataPath + "/" + sapath, unpackerWWW.bytes);
                //could add to some kind of uninstall list?
            }
        }
        yield return 0;
    }
}
