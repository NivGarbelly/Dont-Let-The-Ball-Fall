using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    public Button[] levelButtons;
    void Start()
    {
        GameData data = SaveSystem.LoadGame();
        int levelReached = data.level;
        for (int i = 0; i < levelButtons.Length; i++)
        {
            if (i + 1 > levelReached)
            {
                levelButtons[i].interactable = false;
            }
        }
        
    }
    public void select(int levelName)
    {
        SceneManager.LoadScene(levelName);
    }
}
