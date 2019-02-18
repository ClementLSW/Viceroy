using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static DamagableInterface;

public class PlayerStats : MonoBehaviour, IDamagable
{
    public static float playerScore;
    private float playerMaxHealth;
    public float playerCurrentHealth;
    [SerializeField] private TextMeshProUGUI scoreText;

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

    public void HealthBarUpdate()
    {
        // Use playerCurrentHealth/playerMaxHealth to render healthbar
    }

    public void ScoreUpdate()
    {
        scoreText.SetText("Score : " + playerScore);
    }
}
