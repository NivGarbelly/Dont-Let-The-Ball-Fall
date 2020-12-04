using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLeve : MonoBehaviour
{
    public int highrestLevel;
    void Awake()
    {
        GameData data = SaveSystem.LoadGame();
        highrestLevel = data.level;
        int CurrentScene = SceneManager.GetActiveScene().buildIndex;
       
        if (highrestLevel != CurrentScene)
        {
            SceneManager.LoadScene(highrestLevel);
        }
    }
}