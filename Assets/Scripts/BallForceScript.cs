using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BallForceScript : MonoBehaviour
{
    Rigidbody rigid = new Rigidbody();
    [SerializeField] GameObject Player;

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
        if(Input.GetKeyDown(KeyCode.Q))
        {
            transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y + 1, Player.transform.position.z+5);
            rigid.velocity = new Vector3(0f,0f,0f);
        }
    }
}
