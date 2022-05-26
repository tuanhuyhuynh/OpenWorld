using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public int enemyHealth = 100;
    public bool enemyDead = false;
    public GameObject enemyAI;

    void DamageEnemy(int damageAmount)
    {
        enemyHealth -= damageAmount;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHealth <= 0 && enemyDead == false)
        {
            enemyDead = true;
            //enemyAI.GetComponent<Animator>().Play("Z_Falling Back");
            Score.ScoreValue += 100;
            //GlobalComplete.enemyCount += 1;
            StartCoroutine(Waiting());
        }
    }

    IEnumerator Waiting()
    {
        yield return new WaitForSeconds(1);
        enemyAI.SetActive(false);
    }
}
