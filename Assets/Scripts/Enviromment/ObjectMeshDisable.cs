using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMeshDisable : MonoBehaviour
{
    public GameObject ObjectToDisableMash;

    public GameObject[] ChildrenOfObjectArry;

    private int ChildrenCount;
    //private GameObject Chiled;

    

    private void Start()
    {
        ChildernArry();
    }

    bool CurrentState = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            DisableAll();
        }
    }

    private void ChildernArry()
    {
        ChildrenCount = ObjectToDisableMash.transform.childCount;

        ChildrenOfObjectArry = new GameObject[ChildrenCount];

        for (int i = 0; i < ChildrenCount; i++)
        {
            ChildrenOfObjectArry[i] = ObjectToDisableMash.transform.GetChild(i).gameObject;
        }
    }

    private void DisableAll()
    {          
        ObjectToDisableMash.GetComponent<MeshRenderer>().enabled = CurrentState;
            

        foreach(GameObject Child in ChildrenOfObjectArry)                                       //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!//
        {
            if(Child == null)
            {
                                                                                                 // This is code will cuse unity to not post error masge regurding missing gameobject in arry, this my cuse problames in the futer
            }
            else
            {
                Child.GetComponent<MeshRenderer>().enabled = CurrentState;
            }
           
        }                                                                                      //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!1//

        CurrentState = !CurrentState;
    }

}
