using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData 
{
    public int level;
    
   public GameData (GameManeger GM)
    {
        level = GM.CurrentScene;
    }
}
