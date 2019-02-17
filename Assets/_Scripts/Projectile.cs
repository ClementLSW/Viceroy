using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float bulletVelocity;
    private float decayTime = 5f;
    // Start is called before the first frame update

    void Update()
    {
        transform.Translate(Vector3.forward);
        decayTime -= Time.deltaTime;
        if(decayTime <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision col)
    {
        Destroy(gameObject);
    }
}
