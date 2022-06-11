using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallerController : MonoBehaviour
{
    // Start is called before the first frame update
    BallerInput ballerInput;

    Vector2 currentMovementInput;
    Vector3 currentMovement;

    CharacterController c;
    bool isMovementPressed;
    private void Awake()
    {
        ballerInput = new BallerInput();
        c = GetComponent<CharacterController>();

        ballerInput.CharacterControls.Move.started += context => {
            currentMovementInput = context.ReadValue<Vector2>();
            currentMovement.x = currentMovementInput.x;
            currentMovement.z = currentMovementInput.y;

            isMovementPressed = currentMovementInput.x != 0 || currentMovementInput.y != 0;

        };
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        c.Move(currentMovement * Time.deltaTime);
    }

    private void OnEnable()
    {
        ballerInput.CharacterControls.Enable();
    }
    private void OnDisable()
    {
        ballerInput.CharacterControls.Disable();
    }
}
