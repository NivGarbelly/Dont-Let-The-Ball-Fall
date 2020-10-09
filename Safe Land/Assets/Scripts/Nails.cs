using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nails : MonoBehaviour
{
    public bool isNailed;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private GameObject nails;
    private void Awake()
    {
        if (isNailed==true)
        {
            _rigidbody.isKinematic = true;
            nails.SetActive(true);
        }
        else
        {
            Unnailed();
        }
    }

    public void Unnailed()
    {
        _rigidbody.isKinematic = false;
        nails.SetActive(false); 
    }
}
