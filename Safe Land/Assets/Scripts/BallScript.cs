using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;

    private void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            if (_rigidbody.IsSleeping())
            {
                
            }
        }
    }
}
