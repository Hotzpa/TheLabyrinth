using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour
{
    public static SelfMangment selfMangment;

  


    public string objectID;

    public int SceneIndex;

    public int ChildCount;

    private void Awake()
    {
        selfMangment = FindObjectOfType<SelfMangment>();

        SceneIndex = SceneManager.GetActiveScene().buildIndex;

        objectID = name + transform.position.ToString();

        ChildCount = gameObject.transform.childCount;


    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            Debug.Log("This Game object: " + gameObject + " SceneIndex is: " + SceneIndex.ToString());
        }
    }

    void Start()
    {
        for(int i = 0; i < Object.FindObjectsOfType<DontDestroy>().Length; i++)
        {
            if(Object.FindObjectsOfType<DontDestroy>()[i] != this) 
            {
                if (Object.FindObjectsOfType<DontDestroy>()[i].objectID == objectID)
                {
                    Destroy(gameObject);
                }
            }
         
        }

        


        DontDestroyOnLoad(gameObject);

        /*for(int i=0; i < gameObject.transform.childCount - 1; i++)
        {
            DontDestroyOnLoad(gameObject.transform.GetChild(i));
        */
       
    }

     private void LateUpdate()
    {
        SceneCheck();                                     
    }

    private void SceneCheck()
    {
       for(int i=0; i < ChildCount; i++)
        {
            if (SceneIndex == SceneManager.GetActiveScene().buildIndex && SelfMangment.CollctedDictionary[selfMangment.SelfArray[i]] == false) //&&  i < ChildCount
            {
                gameObject.transform.GetChild(i).gameObject.GetComponent<BoxCollider>().enabled = true;
                gameObject.transform.GetChild(i).gameObject.GetComponent<MeshRenderer>().enabled = true;
            }
            else 
            {
                gameObject.transform.GetChild(i).gameObject.GetComponent<BoxCollider>().enabled = false;
                gameObject.transform.GetChild(i).gameObject.GetComponent<MeshRenderer>().enabled = false;
            }
        }
       
            // gameObject.transform.GetChild(i).gameObject.GetComponent<BoxCollider>().enabled = true;
            // gameObject.transform.GetChild(i).gameObject.GetComponent<MeshRenderer>().enabled = true;
            //  Debug.Log("Index : " + i + " of game objact: " + gameObject.transform.GetChild(i) + " IS in the Dictionray");

        }
        /*else
        {
           
            //gameObject.transform.GetChild(i).gameObject.GetComponent<BoxCollider>().enabled = false;
           // gameObject.transform.GetChild(i).gameObject.GetComponent<MeshRenderer>().enabled = false;
         //   Debug.Log("Index : " + i + " of game objact: " + gameObject.transform.GetChild(i) + " is NOT the Dictionray");


    
        }*/


    }
          
   

   


