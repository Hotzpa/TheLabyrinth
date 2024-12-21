using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolAI : MonoBehaviour
{
    public Player player;

    public GameObject[] WayPoints;

    public GameObject WayPontPrant;
    private GameObject CurrentPoint;


    private int ChildrenCount;
    private int i = 0;

    public float MoveSpeed = 5f;

    private float Ydown = 2f;
    private float Distance;

    private bool NormalWay = true;

    private Vector3 YFix;
    public Vector3 SquishedSize = new Vector3(0, 0.2f, 0);

    private void Start()
    {
        ChildernArry();
    }

    private void Update()
    {
        Potrol();
    }


    private void ChildernArry()
    {
        ChildrenCount = WayPontPrant.transform.childCount;

        WayPoints = new GameObject[ChildrenCount];

        int j = 0;
        for (int i = 0; i < ChildrenCount; i++)
        {
            WayPoints[i] = WayPontPrant.transform.GetChild(j).gameObject;
            j++;
        }
    }

    private void Potrol()
    {
        Distance = Vector3.Distance(gameObject.transform.position, WayPoints[i].transform.position);

        if (Distance < 0.4 && i < WayPoints.Length - 1 && NormalWay == true)
        {
            i++;
        }
        else if (i >= WayPoints.Length - 1)
        {
            NormalWay = false;
        }

        if (Distance < 0.4 && i > 0 && NormalWay == false)
        {
            i--;
        }
        else if (i == 0)
        {
            NormalWay = true;
        }

        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, WayPoints[i].transform.position, MoveSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        YFix = new Vector3(gameObject.transform.position.x, Ydown, gameObject.transform.position.z); // AssToGrass 

        if (collision.gameObject.CompareTag("Player") && player.SmallSize == false && player.SizeRalic == true)// Size Ralic Destroy Start 
        {
            gameObject.transform.localScale = SquishedSize;
            gameObject.transform.position = YFix;

            gameObject.GetComponent<BoxCollider>().enabled = false;

            Destroy(gameObject, 3f);

        }// Size Ralic Destroy End
    }
}
