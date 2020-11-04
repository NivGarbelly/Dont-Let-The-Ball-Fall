using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadLeve : MonoBehaviour
{
    private GameManeger GM;
    public int CurrentScene;
    private void Awake()
    {
    }
    void Start()
    {
        GameData data = SaveSystem.LoadGame();
            CurrentScene = data.level;
            
            if (CurrentScene != 0)
        {
            SceneManager.LoadScene(CurrentScene);
        }
        else
        {
            SceneManager.LoadScene(1);
        }
             if (CurrentScene == null)
            {
                SceneManager.LoadScene(1);
            }
            else
            {
                SceneManager.LoadScene(CurrentScene);
            }
    }

    private void Update()
    {
        print(CurrentScene);
    }
}
