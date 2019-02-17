using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 moveVector;
    private Vector3 lookTarget;
    private float moveSpeed = 8;
    private float sprint;

    private void Update()
    {
        PlayerRotate();
        if(InputManager.horizontalInput!=0 || InputManager.verticalInput != 0)
        {
            sprint = InputManager.GetSprint();
            PlayerMove();
        }
        Debug.DrawRay(transform.position, transform.forward, Color.blue);
    }

    private void PlayerRotate()
    {
        lookTarget = new Vector3(InputManager.hit.point.x, transform.position.y, InputManager.hit.point.z);
        transform.LookAt(lookTarget);
    }

    private void PlayerMove()
    {
        moveVector = new Vector3(InputManager.horizontalInput, 0, InputManager.verticalInput);
        transform.Translate(moveVector * moveSpeed * (sprint + 1f) * Time.deltaTime, Space.World);
    }
}
