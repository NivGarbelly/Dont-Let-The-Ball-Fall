using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructable : MonoBehaviour
{
   [SerializeField] private GameManeger _gameManeger;
   [SerializeField] private GameObject VFX;
       private void OnMouseDown()
       {
           _gameManeger.des.Remove(this.gameObject);
           Instantiate(VFX,transform.position,transform.rotation);
           Destroy(this.gameObject);
       }     
} 
