using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableFloor : MonoBehaviour
{

    public Player player;
    public ParticleSystem BrackEffact;

    private void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();   
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.transform.CompareTag("Player") && player.rb.velocity.y == 0f && player.PowerRlic == true)
        {
            BrackEffact.Play();
            Destroy(gameObject);   
        }
    }
     
   


}
