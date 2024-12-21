using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBoxUpEnemy : MonoBehaviour
{
    public EnemyAI enemyAI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
           
        }
    }
}
