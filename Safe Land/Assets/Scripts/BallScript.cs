using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private sceneManeger GM;
    [SerializeField] private GameObject Fireworks;
    [SerializeField] private GameObject FireworksSound;
    private bool isWinning = false;
    [SerializeField] private ObjMat currentColor;
 [SerializeField] private List<Material> _materials;

    [SerializeField]
        private enum ObjMat
        {
            Regular = 0,
            Halloween = 1,
            Other = 2
        };

        private void Awake()
        {
            GM = GetComponent<sceneManeger>();
        }

        private void FixedUpdate()
    {
        switch (currentColor)
        {
            case ObjMat.Regular:
                GetComponent<Renderer>().material = _materials[Mathf.FloorToInt(0)];
                break;
            case ObjMat.Halloween:
                GetComponent<Renderer>().material = _materials[Mathf.FloorToInt(1)];
                break;
            case ObjMat.Other:
                GetComponent<Renderer>().material = _materials[Mathf.FloorToInt(2)];
                break;
        }
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
