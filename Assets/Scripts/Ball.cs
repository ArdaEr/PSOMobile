using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;


public class Ball : MonoBehaviour
{
    public const float MAX_FORCE = 3000f;
    private SpriteMask forceSpriteMask;
    public bool ontrigger;

    private void Start()
    {
        forceSpriteMask = GetComponent<SpriteMask>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ontrigger = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ontrigger = false;
        }
    }
    public void Launch(float force)
    {
        if (ontrigger)
        {
            Vector3 dir = (UtilsClass.GetMouseWorldPositionWithZ() - transform.position).normalized * -1f;
            transform.GetComponent<Rigidbody>().velocity = dir * force * 5;
            forceSpriteMask.alphaCutoff = 1;
        }
    }

    public void ShowForce(float force)
    {
        forceSpriteMask.alphaCutoff = 1 - force / MAX_FORCE;
    }
}
