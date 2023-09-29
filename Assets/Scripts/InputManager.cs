using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    //Player Controls
    private PlayerControl playerControl;

    public Vector2 movementInput;
    public float verticalInput;
    public float horizontalInput;

    public void OnEnable()
    {
        if (playerControl == null)
        {
            playerControl = new PlayerControl();
            //When we hit WASD, record the movement to the variable movementInput using lambda expression
            playerControl.PlayerControls.WASD.performed += i => movementInput = i.ReadValue<Vector2>();
        }
        playerControl.Enable();
    }

    private void OnDisable()
    {
        playerControl.Disable();
    }

    public void HandleAllInput()
    {
        HandleMovementInput();
    }

    private void HandleMovementInput()
    {
        verticalInput  = movementInput.y;
        horizontalInput = movementInput.x;
    }
}
