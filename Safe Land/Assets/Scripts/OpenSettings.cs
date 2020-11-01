using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OpenSettings : MonoBehaviour
{
    [SerializeField] GameObject systemPanel;

    public void OpenSystemPanel()
    {
        if(systemPanel.activeSelf == true)
        {
            systemPanel.SetActive(false);
        }
        else
        {
            systemPanel.SetActive(true);
        }
        
       
    }
}
