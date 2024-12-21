using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerRalic : MonoBehaviour
{
    public Player player;

    private void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
    }

    private void OnTriggerEnter(Collider other)
    {
        player.PowerRlic = true; 
        Destroy(gameObject);
    }
}
