using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static DamagableInterface;

public class PlayerStats : MonoBehaviour, IDamagable
{
    public static float playerScore;
    private float playerMaxHealth;
    public float playerCurrentHealth;

    // Start is called before the first frame update
    void Start()
    {
        playerScore = 0;
        playerMaxHealth = 100;
        playerCurrentHealth = playerMaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        CheckHealth();
    }

    #region IDamagable

    public void TakeDamage(float dmg)
    {
        playerCurrentHealth -= dmg;
    }

    public void CheckHealth()
    {
        if (playerCurrentHealth <= 0)
        {
            //Die
        }
        else
        {
            UpdateHealthBar();
        }
    }
    #endregion

    public void UpdateHealthBar()
    {
        // Use playerCurrentHealth/playerMaxHealth to render healthbar
    }
}
