using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OpenSettings : MonoBehaviour
{
    [SerializeField] GameObject systemPanel;

    private void Awake()
    {
        Time.timeScale = 1;
    }

    public void OpenSystemPanel()
    {
        if(systemPanel.activeSelf == true)
        {
            systemPanel.SetActive(false);
            Time.timeScale = 1;
        }
        else
        {
            systemPanel.SetActive(true);
            Time.timeScale = 0;
        }
        
       
    }
}
