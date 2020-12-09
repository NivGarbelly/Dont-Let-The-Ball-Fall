using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    public Button[] levelButtons;
    
    public void select(int levelName)
    {
        SceneManager.LoadScene(levelName);
    }
}
