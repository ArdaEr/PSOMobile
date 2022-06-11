using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody _rigid;
    private void Start()
    {      
        _rigid = GetComponent<Rigidbody>();
    }
    void OnJump(InputValue value)
    {
        if (value.isPressed)
        {
            _rigid.velocity += new Vector3(0f,10f, 0f);
            Debug.Log("cýpcýp");
        }
    }
}
