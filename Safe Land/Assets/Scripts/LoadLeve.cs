using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadLeve : MonoBehaviour
{
    private GameManeger GM;
    public int CurrentScene;
 
    void Start()
    {
        SceneManager.LoadScene(1);
       // GameData data = SaveSystem.LoadGame();
           // CurrentScene = data.level;
            
        //    if (CurrentScene != 0)
      //  {
     //       SceneManager.LoadScene(CurrentScene);
    //    }
     //   else
    //    {
    //        SceneManager.LoadScene(1);
    //    }
            
      //      if (CurrentScene == null)
      //      {
       // SceneManager.LoadScene(1);
     //       }
    }
}
