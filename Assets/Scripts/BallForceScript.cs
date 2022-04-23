using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallForceScript : MonoBehaviour
{
    Rigidbody rigid = new Rigidbody();
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        rigid.AddForce(-transform.forward * 1000, ForceMode.Acceleration);
        rigid.useGravity = true;
        Debug.Log("Vurdu");
    }
}
