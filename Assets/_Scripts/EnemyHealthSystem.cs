using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static DamagableInterface;

public class EnemyHealthSystem : MonoBehaviour, IDamagable
{
    private Text hpDisplay;
    [SerializeField] private float hp;
    private EnemyLootSystem els;
    
    // Start is called before the first frame update
    void Start()
    {
        //hpDisplay.text = hp.ToString();
        els = gameObject.GetComponent<EnemyLootSystem>();
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
            els.drop();
            Destroy(gameObject);
        }
        else
        {
            UpdateHealthBar();
        }
    }

    public void TakeDamage(float dmg)
    {
        hp -= dmg;
        Debug.Log(gameObject.name + "'s HP Left: " + hp.ToString());
    }

    public void UpdateHealthBar()
    {

    }
}
