using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Self : MonoBehaviour
{
    public static SelfMangment selfMangment;

    public GameObject SelfCollectEffectHolder;
    

    //private static int SeneIndex;


    private void Start()
    {
        selfMangment = GameObject.Find("GameManger").GetComponent<SelfMangment>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            for (int i = 0; i < selfMangment.SelfArray.Length; i++)
            {
                if(selfMangment.SelfArray[i] == gameObject)
                {
                    SelfMangment.CollctedDictionary[selfMangment.SelfArray[i]] = true;
                    SelfMangment.SelfCount++;
                    Debug.Log("ooch"); 
                }                               
            }
            CollectSelfEffect();

           DisableSelf();
          
        }

            
    }

    private void CollectSelfEffect()
    {
        Instantiate(SelfCollectEffectHolder, gameObject.transform);
    }

    public void DisableSelf()
    {
        gameObject.GetComponent<BoxCollider>().enabled = false;
        gameObject.GetComponent<MeshRenderer>().enabled = false;     
    }

    

}
