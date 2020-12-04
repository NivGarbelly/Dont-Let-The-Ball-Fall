using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManeger : MonoBehaviour
{
    public int CurrentScene;
    public int highestLevel;

    private void Awake()
    {
     CurrentScene=SceneManager.GetActiveScene().buildIndex;
     GameData data = SaveSystem.LoadGame();
             highestLevel = data.level;
             if (CurrentScene>=highestLevel)
             {
                 highestLevel = CurrentScene;
                 SaveSystem.SaveGame(this);
             }
    }
    
    public void LoadNextScene()
    {
            SceneManager.LoadScene(CurrentScene + 1);
    }
}
