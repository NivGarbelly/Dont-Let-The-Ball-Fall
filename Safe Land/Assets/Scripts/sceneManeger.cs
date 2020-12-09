using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManeger : MonoBehaviour
{
    public int CurrentScene;
    public int highestLevel;
    
    public void LoadNextScene()
    {
            SceneManager.LoadScene(CurrentScene + 1);
    }
}
