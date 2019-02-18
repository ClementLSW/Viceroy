using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private GameObject player;
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

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            player.GetComponent<Skill_Nuke>().Activate();
        }
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

    public static float GetSprint()
    {
        if(Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            return 1;
        }
        return 0;
    }
    
}
