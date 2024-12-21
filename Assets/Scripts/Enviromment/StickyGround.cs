using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyGround : MonoBehaviour
{
    public Player player; 
    private void OnCollisionEnter(Collision collision)
    {
        player.Speed = 0.1f;
        player.JumpForce /= 4f;
    }

    private void OnCollisionExit(Collision collision)
    {
        player.Speed = 1.5f;
        player.JumpForce *= 4f;
    }
}
