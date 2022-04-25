using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallHoldScript : MonoBehaviour
{
    [SerializeField] Ball ball;

    [SerializeField]private Slider shotbar;
    [SerializeField]private Slider passbar;

    public float timer = 0f;

    private void Awake()
    {
        //slider = gameObject.GetComponent<Slider>();    
    }

    // Update is called once per frame
    private void Update()
    {
        
        if (Input.GetMouseButton(0))
        {
            timer += Time.deltaTime * 1.8f;
            shotbar.value = timer;
        }
        if (Input.GetMouseButton(1))
        {
            timer += Time.deltaTime * 1.2f;
            passbar.value = timer;
        }
        if (Input.GetMouseButtonUp(0))
        {
            if (timer>=1.2f)
            {
                timer = 1.2f;
            }
            ball.Launch(timer * 7f);
            Debug.Log(timer);
            timer = 0f;
            shotbar.value = 0f;
        }
        if (Input.GetMouseButtonUp(1))
        {
            if (timer >= 0.75f)
            {
                timer = 0.75f;
            }
            ball.Launch(timer*4.2f);
            Debug.Log(timer);
            passbar.value = 0f;
            timer = 0f;
        }
    }
}
