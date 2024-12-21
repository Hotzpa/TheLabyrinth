using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SelfMangment : MonoBehaviour
{
   

    public  GameObject[] SelfArray;
   // public  bool[] SelfCollectedCheck;

    public static Dictionary<GameObject, bool> CollctedDictionary; // was int and bool
  
    //public static List<bool> ColtlectedAllGame;
    

    public GameObject SelfHolder;

   public static int ChildCount;

    public static int SelfCount;
    private static bool RanOnce = false;

    
  

    private void Start()
    {
       

        ChildCount = GameObject.Find("SelfHolder" + SceneManager.GetActiveScene().buildIndex.ToString()).transform.childCount;
        SelfHolder = GameObject.Find("SelfHolder" + SceneManager.GetActiveScene().buildIndex.ToString()).gameObject;
        
      

        SelfArrays();

        ListConfiguration();

        DistroySelf();



    }

    private void SelfArrays()
    {
        SelfArray = new GameObject[ChildCount];
        //SelfCollectedCheck = new bool[ChildCount];  

        for (int i = 0; i < SelfArray.Length; i++)
        {
            SelfArray[i] = SelfHolder.transform.GetChild(i).gameObject;                  
        }
       /* for (int i = 0; i < SelfCollectedCheck.Length; i++)
        {
            SelfCollectedCheck[i] = false;
        }*/

        
    }

    private  void ListConfiguration()
    {
    
        if(RanOnce == false)
        {
            //ColtlectedAllGame = new List<bool>();
            CollctedDictionary = new Dictionary<GameObject, bool>();
            RanOnce = true;           
        }

        for (int i = 0; i < SelfArray.Length; i++) 
        {
             if(CollctedDictionary.ContainsKey(SelfArray[i]) == false)
            {
                CollctedDictionary.Add(SelfArray[i], false);
            }
            
            

        }
    }

    private void DistroySelf()
    {
         for (int i = 0; i < SelfArray.Length; i++)
        {
            if(CollctedDictionary[SelfArray[i]] == true)
            {
                SelfArray[i].GetComponent<BoxCollider>().enabled = false;
                SelfArray[i].GetComponent<MeshRenderer>().enabled = false;
                //Debug.Log("SetFauls");
            }
        }

         
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            lol();
        }
    }

    private void lol()
    {
        int index = 0;

        foreach (var kvp in CollctedDictionary)
        {
            Debug.Log("Index" + index + " => key: " + kvp.Key + ", value: " + kvp.Value);
            index++;
        }
    }



}
