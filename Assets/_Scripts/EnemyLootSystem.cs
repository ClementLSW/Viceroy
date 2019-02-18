using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLootSystem : MonoBehaviour
{
    private EnemyManager em;

    public void drop()
    {
        em = gameObject.GetComponent<EnemyManager>();
        CalculateDropScore();
        CalculateDropLoot();
    }

    void CalculateDropScore()
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
    }

    void CalculateDropLoot()
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
