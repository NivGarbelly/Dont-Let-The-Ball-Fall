using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructable : MonoBehaviour
{
   [SerializeField] private GameManeger _gameManeger;
       private void OnMouseDown()
       {
           _gameManeger.des.Remove(this.gameObject);
           Destroy(this.gameObject);
       }

       private void OnDestroy()
       {
           _gameManeger.des.Remove(this.gameObject);
       }
} 
