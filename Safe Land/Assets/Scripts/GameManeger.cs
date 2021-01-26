using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManeger : MonoBehaviour
{

    public List<GameObject> des = new List<GameObject>();
    public List<GameObject> undes = new List<GameObject>();
    public GameObject ball;
    private bool _isballNotNull;
    

    void Awake()
    {
        Screen.orientation = ScreenOrientation.Portrait;  
        _isballNotNull = ball != null;
        foreach (var desObj in GameObject.FindGameObjectsWithTag("Des"))
        {
            des.Add(desObj);
        }

        foreach (var undesObj in GameObject.FindGameObjectsWithTag("Undes"))
        {
            undes.Add(undesObj);
        }
    }
    
    void Update()
    {
        if (des.Count == 0 && _isballNotNull)
        {
            foreach (var undesObj in undes)
            {
                Destroy(undesObj);
            }
            undes.Clear();
        }
        if (ball==null)
        {
            restartLevel();
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        Destroy(other.gameObject);
    }
    
    public void restartLevel()
    {
        var currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);
    }

    


}
