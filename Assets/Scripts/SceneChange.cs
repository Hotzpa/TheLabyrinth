using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public int SceneNumber;

    //public Player player;
    public PlayerDataPrefs playerDataPrefs;

    public GameObject DestroyBeforeLode;


    private void OnApplicationQuit()
    {
       SelfMangment.CollctedDictionary.Clear();
       PlayerPrefs.DeleteAll();
       Debug.Log("Delete");
    }
    private void Awake()
    {
        playerDataPrefs = GameObject.Find("GameManger").GetComponent<PlayerDataPrefs>();
    }

    private void Update()
    {
        DestroyBeforeLode = GameObject.Find("PointToFollow(Clone)");
    }

    private void Start()
    {
        playerDataPrefs = GameObject.Find("GameManger").GetComponent<PlayerDataPrefs>();
       
       playerDataPrefs.DataToLode();       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if(DestroyBeforeLode != null)
            Destroy(DestroyBeforeLode);

            LoadScene();
        }
    }

   

    public void LoadScene()
    {
        playerDataPrefs.DataUpdat();
        SceneManager.LoadScene(SceneNumber); 
    }
}
