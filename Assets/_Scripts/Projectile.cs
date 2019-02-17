using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static DamagableInterface;

public class Projectile : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float bulletVelocity;
    private float currentDamage;
    private float decayTime = 5f;

    // Start is called before the first frame update
    void Start()
    {
        currentDamage = 1f;
    }

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
        IDamagable hitObj = col.gameObject.GetComponent<IDamagable>();
        if(hitObj != null)
        {
            hitObj.TakeDamage(currentDamage);
        }
        Destroy(gameObject);
    }
}
