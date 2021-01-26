using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Nails : MonoBehaviour
{
    public bool isNailed;
    [SerializeField] private Rigidbody rigidbody;
    [SerializeField] private GameObject nails;
    
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        if (isNailed==true)
        {
            rigidbody.isKinematic = true;
            nails.SetActive(true);
        }
        else
        {
            Unnailed();
        }
    }

    public void Unnailed()
    {
        rigidbody.isKinematic = false;
        nails.SetActive(false); 
    }
}
