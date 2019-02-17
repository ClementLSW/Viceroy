using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static DamagableInterface;

public class EnemyHealthSystem : MonoBehaviour, IDamagable
{
    private Text hpDisplay;
    private float hp;
    
    // Start is called before the first frame update
    void Start()
    {
        hpDisplay.text = hp.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        CheckHealth();
    }
    
    public void CheckHealth()
    {
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            hpDisplay.text = hp.ToString();
        }
    }

    public void TakeDamage(float dmg)
    {
        hp -= dmg;
    }
}
