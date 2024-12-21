using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectEffect : MonoBehaviour
{

    public GameObject PlayerObj;

    //private ParticleSystem particleSystem;

    public float Speed = 4f;

    private void Start()
    {
        PlayerObj = FindObjectOfType<Player>().gameObject;

        // particleSystem = gameObject.GetComponentInChildren<ParticleSystem>();

        Destroy(gameObject, 4f);
    }

    private void Update()
    {
        Chase();
    }

    public void Chase()
    {
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, PlayerObj.transform.position, Speed * Time.deltaTime);
    }
}
