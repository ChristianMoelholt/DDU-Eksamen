using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader2_3 : MonoBehaviour
{
    public int iSceneToLoad;
    public string sSceneToLoad;
    public bool loadByInt;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            LoadScene();
        }
    }

    private void LoadScene()
    {
        if (loadByInt == true)
        {
            SceneManager.LoadScene(iSceneToLoad);
        }
        else
        {
            SceneManager.LoadScene(sSceneToLoad);
        }
    }
}
