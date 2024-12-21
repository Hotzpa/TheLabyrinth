using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public GameObject PlayerObj;


    public Player player;

    public GameObject HitBoxUp;

    public float Speed =5f;
    private float Ydown = 2f;

    private bool SetActiv = true;

    public Vector3 SquishedSize = new Vector3(0,0.2f,0);
    private Vector3 YFix;

    private void Awake()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        PlayerObj = GameObject.Find("Player");
    }
    

    // Update is called once per frame
    void Update()
    {      
        Chase();
        FallOff();
    }

    public void Chase()
    {
        if(SetActiv == true)
        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, PlayerObj.transform.position, Speed * Time.deltaTime);       
    }

    private void OnCollisionEnter(Collision collision)
    {
        YFix = new Vector3(gameObject.transform.position.x, Ydown, gameObject.transform.position.z); // AssToGrass 

        if (collision.gameObject.CompareTag("Player") && player.SmallSize == false && player.SizeRalic == true)// Size Ralic Destroy Start
        {
            gameObject.transform.localScale = SquishedSize;
            gameObject.transform.position = YFix;

            gameObject.GetComponent<BoxCollider>().enabled = false;

            SetActiv = false;

            Destroy(gameObject,3f);

        }// Size Ralic Destroy End

        
    }

    private void FallOff()
    {
        if (gameObject.transform.position.y < -5)
            Destroy(gameObject);
    }


}
