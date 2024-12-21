using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brige : MonoBehaviour
{
    public Player player;

    private bool OneTime = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && player.SmallSize == false && player.SizeRalic == true && OneTime==false) 
        {
            BrigeMove();
            OneTime = true;
        }

        
    }

    private void BrigeMove() 
    {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z +2);
        gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);

        gameObject.tag = "Ground";
    }
}
