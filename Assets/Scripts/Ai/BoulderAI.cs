using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoulderAI : MonoBehaviour
{
    public Player player;


    public float BoulderSpeed = 20f;

    public GameObject PlayerObj;

    public Vector3 SquishedSize = new Vector3(1f, 0.2f, 1f);

    private void Awake()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        PlayerObj = GameObject.Find("Player");

        gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0f, 0f, BoulderSpeed) * Time.deltaTime, ForceMode.VelocityChange);
    }
    /*private void FixedUpdate()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0f, 0f, BoulderSpeed) * Time.deltaTime, ForceMode.VelocityChange);
    }*/

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerSquish();
        }
    }

    private void PlayerSquish()
    {
        PlayerObj.transform.localScale = SquishedSize;
        PlayerObj.GetComponent<SphereCollider>().enabled = false;
        PlayerObj.AddComponent<BoxCollider>();

        player.JumpRalicAdd = 0f; //Stop Jump
        player.Speed = 0f; // Stop Movment

        Invoke("SceenReset",4f);
        
    }

    private void SceenReset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
