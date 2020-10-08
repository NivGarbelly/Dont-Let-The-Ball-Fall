﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Expolsion : MonoBehaviour
{
    [SerializeField] private GameManeger _gameManeger;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float power;
    [SerializeField] private float radius;
    [SerializeField] private GameObject VFX;
    private void OnMouseDown()
    {
        Vector3 explosionPos = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();

            if (rb != null)
                rb.AddExplosionForce(power, explosionPos, radius, 3.0F);
        }

        Instantiate(VFX,transform.position,transform.rotation);
        _gameManeger.des.Remove(this.gameObject);
       Destroy(this.gameObject);
    }

    private void OnDestroy()
    {
        _gameManeger.des.Remove(this.gameObject);
    }
}
