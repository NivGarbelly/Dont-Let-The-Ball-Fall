using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragBox : MonoBehaviour
{
    [SerializeField] private string MouseXinput, MouseYinput;
    [SerializeField] private float MouseSensetivity;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private bool isTouchFloor;
    private void OnMouseDrag()
    {
        float MouseX = Input.GetAxis(MouseXinput) * MouseSensetivity * Time.deltaTime;
        float MouseY = Input.GetAxis(MouseYinput) * MouseSensetivity * Time.deltaTime;
        Vector3 dir=  new Vector3(MouseX,MouseY,transform.position.z);
        Vector3 targetDir = dir - transform.position;
        float angle = Vector3.Angle(targetDir, transform.forward);
        if (isTouchFloor==false)
        {
            _rigidbody.isKinematic = true;
        }
        else
        {
            _rigidbody.isKinematic = false;
        }
        
    }

    private void OnMouseUp()
    {
        _rigidbody.isKinematic = false;
    }

    private void OnCollisionStay(Collision other)
    {
        isTouchFloor = true;
    }
    private void OnCollisionExit(Collision other)
    {
        isTouchFloor = false;
    }
}
