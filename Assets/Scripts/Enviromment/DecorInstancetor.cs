using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecorInstancetor : MonoBehaviour
{

    public GameObject NormalDecor;
    public GameObject WeirdDecor;
    public GameObject BlokeyDecor;

    

    private void Start()
    {
        InstantiateDecor();
    }

    private void InstantiateDecor()
    {
       
        if(SelfMangment.SelfCount <= 3)
        {
            Instantiate(NormalDecor, gameObject.transform.position, gameObject.transform.rotation);
        }
        else if(SelfMangment.SelfCount > 3 && SelfMangment.SelfCount < 6)
        {
            Instantiate(WeirdDecor, gameObject.transform.position, gameObject.transform.rotation);
        }
        else if(SelfMangment.SelfCount >= 6)
        {
            Instantiate(BlokeyDecor, gameObject.transform.position, gameObject.transform.rotation);
        }



       /* switch (SelfMangment.SelfCount)
        {
            default:
                Instantiate(NormalDecor, gameObject.transform.position, gameObject.transform.rotation);
                break;
            case 3:
                Instantiate(NormalDecor, gameObject.transform.position, gameObject.transform.rotation);
                break;
            case 1:
                Instantiate(WeirdDecor, gameObject.transform.position, gameObject.transform.rotation);
                break;
            case 2:
                Instantiate(BlokeyDecor, gameObject.transform.position, gameObject.transform.rotation);
                break;
        }*/
    }
}
