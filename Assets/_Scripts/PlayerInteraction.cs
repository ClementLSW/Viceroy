using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private Transform ft;
    [SerializeField] private GameObject projectilePrefab;
    private bool coolDown;
    [SerializeField] private float cdTime = .3f;
    private float cdCounter;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetMouseButton(0) && !coolDown)
        {
            PlayerFire();
            coolDown = true;
            Debug.Log("Fire");
        }
        else
        {
            //Debug.Log("Cooldown: " + cdCounter.ToString());
            cdCounter -= Time.deltaTime;
            if(cdCounter <= 0f)
            {
                coolDown = false;
            }
        }
    }

    private void PlayerFire()
    {
        Instantiate(projectilePrefab, ft.position, ft.rotation);
        cdCounter = cdTime;
    }
}
