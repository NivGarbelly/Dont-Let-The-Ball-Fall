using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private GameManeger GM;
    [SerializeField] private GameObject Fireworks;
    [SerializeField] private GameObject FireworksSound;
    private bool isWinning = false;

    private void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            if (_rigidbody.IsSleeping())
            {
                Invoke("Win", 2f);
                if (isWinning == false)
                {
                    Instantiate(Fireworks);
                    Instantiate(FireworksSound);
                    isWinning = true;
                }

              
            }
        }
    }

    private void Win()
    {
        GM.LoadNextScene();
    }
   
}
