using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLootSystem : MonoBehaviour
{
    private EnemyManager em;

    public void drop()
    {
        em = gameObject.GetComponent<EnemyManager>();
        calculateDropScore();
        calculateDropLoot();
    }

    void calculateDropScore()
    {
        switch (em.EnemyType)
        {
            case 0: PlayerStats.playerScore += 10;
                break;

            case 1: PlayerStats.playerScore += 30;
                break;

            case 2: PlayerStats.playerScore += 50;
                break;

            case 3: PlayerStats.playerScore += 100;
                break;
        }

        //This is just for debug. Maybe in the future can call UpdateScore() in PlayerStats
        Debug.Log("Score: " + PlayerStats.playerScore);
    }

    void calculateDropLoot()
    {
        float rng = Random.Range(0, 9);

        switch (rng)
        {
            case 0: /*Drop Item 0*/
                break;

            case 1: /*Drop Item 1*/
                break;

            case 2: /*Drop Item 2*/
                break;

            case 3: /*Drop Item 3*/
                break;
        }
    }
}
