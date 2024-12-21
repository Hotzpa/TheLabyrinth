using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemyTrigger : MonoBehaviour
{
    public EnemySpwner enemySpwner;

    public bool MultipleEnemys = false;



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && MultipleEnemys == true)
            enemySpwner.EnemeySpawnMultiple();
        if(other.gameObject.CompareTag("Player") && MultipleEnemys == false)
            enemySpwner.EnemeySpawnSingle();
    }
}
