using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpRalic : MonoBehaviour
{
    public Player player;

    public float Multiplier = 1.5f;

    private void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
    }

    private void OnTriggerEnter(Collider other) // canged all player to static
    {
        player.JumpRalicAdd = Multiplier;
        player.JumpAdjust = 5f;
        player.Gravity = 0.8f;
        player.JumpRalic = true;
        Destroy(gameObject);
    }
}
