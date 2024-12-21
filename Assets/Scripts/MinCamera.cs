using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinCamera : MonoBehaviour
{

    public Transform PlayerTransform;

    [SerializeField] private MeshRenderer[] ChildrenMasharry;

    public Vector3 TransformOffSet = new Vector3(0f,4f,-10f);
    public Vector3 RotationOffSet = new Vector3(20f, 0f, 0f);

    private void Start()
    {
        gameObject.transform.Rotate(RotationOffSet);
    }

    private void Update()
    {
        gameObject.transform.position = PlayerTransform.position + TransformOffSet;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Decor"))
        {
            ChildrenMasharry = other.GetComponentsInChildren<MeshRenderer>();  
            
            for(int i = 0; i < ChildrenMasharry.Length; i++)
            {
                ChildrenMasharry[i].enabled = false;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Decor"))
        {
            for (int i = 0; i < ChildrenMasharry.Length; i++)
            {
                ChildrenMasharry[i].enabled = true;
            }
        }
    }

}
