using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocomotion : MonoBehaviour
{
    Vector3 moveDirection;
    Transform cameraObject;


    private void Start()
    {
        cameraObject = Camera.main.transform;
    }

    public void HandlesAllMovement()
    {
        HandlesMovement();
        HandlesRotation();
    }

    private void HandlesMovement()
    {
        moveDirection = cameraObject.forward * PlayerManager.Instance.inputManager.verticalInput;
        moveDirection = moveDirection + cameraObject.right * PlayerManager.Instance.inputManager.horizontalInput;
        moveDirection.Normalize();
        moveDirection.y = 0;
        moveDirection = moveDirection * PlayerManager.Instance.moveSpeed;
    }

    private void HandlesRotation()
    {

    }

}
