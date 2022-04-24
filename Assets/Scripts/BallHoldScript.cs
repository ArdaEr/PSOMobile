using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHoldScript : MonoBehaviour
{
    [SerializeField] Ball ball;


    private float holdDownStartTime;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            holdDownStartTime = Time.time;

        }
        if (Input.GetMouseButtonUp(0))
        {
            //float holdDownTime = Time.time - holdDownStartTime;
            //ball.Launch(CalculateHoldDownForce(holdDownTime));
        }

        if (Input.GetMouseButton(0))
        {
            //float holdDownTime = Time.time - holdDownStartTime;
            ball.Launch(6f);

        }
        if (Input.GetMouseButton(1))
        {
            //float holdDownTime = Time.time - holdDownStartTime;
            ball.Launch(3f);

        }
    }

    private float CalculateHoldDownForce(float holdtime)
    {
        float maxForceHoldDownTime = 2f;
        float holdTimeNormalized = Mathf.Clamp01(holdtime / maxForceHoldDownTime);
        float force = holdTimeNormalized * Ball.MAX_FORCE;
        return force;
    }
}
