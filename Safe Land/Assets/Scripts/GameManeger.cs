﻿using System;
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
    public int CurrentScene;

    void Awake()
    {
        CurrentScene = SceneManager.GetActiveScene().buildIndex;
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

    private void Start()
    {
        SaveSystem.SaveGame(this);
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
        print(CurrentScene);
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

    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


}
