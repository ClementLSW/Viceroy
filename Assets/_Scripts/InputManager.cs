using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static float horizontalInput;
    public static float verticalInput;

    [SerializeField] private Camera cam;
    private Ray ray;
    public static RaycastHit hit;

    // Update is called once per frame
    void Update()
    {
        GetMousePosition();
        GetMovementInput();
    }

    private void GetMousePosition()
    {
        Physics.Raycast(cam.ScreenPointToRay(Input.mousePosition), out hit);
    }

    private void GetMovementInput()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }
}
