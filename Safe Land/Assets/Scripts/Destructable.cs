using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructable : MonoBehaviour
{
   [SerializeField] private GameManeger _gameManeger;
   [SerializeField] private GameObject VFX;
   [SerializeField] private GameObject SFX;
   private void OnMouseDown()
       {
           Instantiate(VFX,transform.position,transform.rotation);
           Instantiate(SFX,transform.position,transform.rotation);
           _gameManeger.des.Remove(this.gameObject);
           Destroy(this.gameObject);
       }

   private void Awake()
   {
       var rigidbody = GetComponent<Rigidbody>();
       rigidbody.mass = transform.localScale.x;
   }
   
} 
