using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static DamagableInterface;

public class PlayerStats : MonoBehaviour, IDamagable
{
    public static float playerScore;
    private float playerMaxHealth;
    public float playerCurrentHealth;
    private Rigidbody rb;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private Slider playerHealthBar;

    // Initializing stats
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerScore = 0;
        playerMaxHealth = 100;
        playerCurrentHealth = playerMaxHealth;
        playerHealthBar.maxValue = playerMaxHealth;
        playerHealthBar.value = playerCurrentHealth;
    }
    
    // Every loop, playerStats checks health, score
    void Update()
    {
        CheckHealth();
        ScoreUpdate();
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
            Destroy(gameObject);
        }
        else
        {
            HealthBarUpdate();
        }
    }
    #endregion

    #region UI Update Stuff
    public void HealthBarUpdate()
    {
        playerHealthBar.value = playerCurrentHealth;
    }

    public void ScoreUpdate()
    {
        scoreText.SetText("Score : " + playerScore);
    }

    public void ApplyPushForce(Vector3 force)
    {
        rb.AddForce(force);
    }
    #endregion
}
