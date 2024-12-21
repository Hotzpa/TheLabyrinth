using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NpcText : MonoBehaviour
{
    public GameObject player;
    public TMP_Text Text;

    private void Start()
    {
        player = GameObject.Find("Player");
    }

    

    private void OnTriggerEnter(Collider other)
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
    }

}
