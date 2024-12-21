using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallRalic : MonoBehaviour
{
    public Vector3 HalfeScale = new Vector3(-0.5f,-0.5f,-0.5f);

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Prass F to change size");
        other.transform.localScale += HalfeScale;
        Destroy(gameObject);
    }

}
