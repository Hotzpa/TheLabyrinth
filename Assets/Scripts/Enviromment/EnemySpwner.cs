using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpwner : MonoBehaviour
{

    public GameObject EnmemyPrefab;

    public int AmountToSpwan;

    public void EnemeySpawnMultiple()
    {
        for (int i = 0; i <= AmountToSpwan; i++)
        {
            
            Instantiate(EnmemyPrefab, new Vector3(Random.Range(-1f, 5f), 0, Random.Range(1f, 2f)) + gameObject.transform.position, gameObject.transform.rotation);
        }
    }

    public void EnemeySpawnSingle()
    {
        Instantiate(EnmemyPrefab, gameObject.transform.position, gameObject.transform.rotation);
    }

}
