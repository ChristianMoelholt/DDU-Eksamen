using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    public static LevelManager main;
    public Transform startPoint;
    public Transform StartPoint2;
    public Transform StartPoint3;
    public Transform StartPoint4;

    private void Awake()
    {
        main = this;
        if (LevelManager.instance == null) instance = this;
        else Destroy(gameObject);
    }

    public void GameOver()
    {
        UIManager ui = GetComponent<UIManager>();
        if (ui != null)
        {
            ui.ToggleDeathPanel();
        }
    }
}
