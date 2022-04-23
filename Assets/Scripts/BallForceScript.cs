using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BallForceScript : MonoBehaviour
{
    Rigidbody rigid = new Rigidbody();
    private void Start() {
        rigid = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        rigid.AddForce(transform.forward * 100, ForceMode.Acceleration);
        rigid.useGravity = true;
        Debug.Log("Vurdu");
    }
    private void Update() {
        if(Input.GetKeyDown(KeyCode.X))
        {
            rigid.AddForce(transform.right * 1000, ForceMode.Acceleration);
            rigid.useGravity = true;
            Debug.Log("Vurdu");
        }
    }
}
