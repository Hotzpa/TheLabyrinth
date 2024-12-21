using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataPrefs : MonoBehaviour
{
    public Player player;

    private static bool RunOnce = false;

    public float JumpForce;
    public float JumpRalicAdd;
    public float JumpAdjust;
    public float Gravity;

    public bool CanBrakeStuff;
    public bool SmallSize;
    public bool SizeRalic;
    public bool PowerRlic;

    private void OnEnable()
    {
        player = GameObject.Find("Player").GetComponent<Player>();

        if (RunOnce == false)
        {
            DataUpdat();
            RunOnce = true;
        }

    }
    private void Start()
    {
        //DataUpdat();
    }


    public PlayerDataPrefs(Player player)
    {
        JumpForce = player.JumpForce;
        JumpRalicAdd = player.JumpRalicAdd;
        JumpAdjust = player.JumpAdjust;

        //CanBrakeStuff = player.CanBrakeStuff;
        SmallSize = player.SmallSize;
        SizeRalic = player.SizeRalic;
        PowerRlic = player.PowerRlic;
    }

    public void DataUpdat()
    {
        JumpForce = player.JumpForce;
        JumpRalicAdd = player.JumpRalicAdd;
        JumpAdjust = player.JumpAdjust;
        Gravity = player.Gravity;

        //CanBrakeStuff = player.CanBrakeStuff;
        SmallSize = player.SmallSize;
        SizeRalic = player.SizeRalic;
        PowerRlic = player.PowerRlic;

        DataToSave();
    }

    public void DataToSave()
    {
        /*JumpForce = player.JumpForce;
        JumpRalicAdd = player.JumpRalicAdd;
        JumpAdjust = player.JumpAdjust;

        CanBrakeStuff = player.CanBrakeStuff;
        SmallSize = player.SmallSize;
        SizeRalic = player.SizeRalic;
        PowerRlic = player.PowerRlic;*/

        PlayerPrefs.SetFloat("JumpForce", JumpForce);
        PlayerPrefs.SetFloat("JumpRalicAdd", JumpRalicAdd);
        PlayerPrefs.SetFloat("JumpAdjust", JumpAdjust);
        PlayerPrefs.SetFloat("Gravity", Gravity);

        PlayerPrefs.SetInt("CanBrakeStuff", System.Convert.ToInt32(CanBrakeStuff));
        PlayerPrefs.SetInt("SmallSize", System.Convert.ToInt32(SmallSize));
        PlayerPrefs.SetInt("SizeRalic", System.Convert.ToInt32(SizeRalic));
        PlayerPrefs.SetInt("PowerRlic", System.Convert.ToInt32(PowerRlic));

        PlayerPrefs.Save();

        Debug.Log("Save");
    }

    public void DataToLode()
    {
        player.JumpForce = PlayerPrefs.GetFloat("JumpForce");
        player.JumpRalicAdd = PlayerPrefs.GetFloat("JumpRalicAdd");
        player.JumpAdjust = PlayerPrefs.GetFloat("JumpAdjust");
        player.Gravity = PlayerPrefs.GetFloat("Gravity", Gravity);


       // player.CanBrakeStuff = System.Convert.ToBoolean(PlayerPrefs.GetInt("CanBrakeStuff"));
        player.SmallSize = System.Convert.ToBoolean(PlayerPrefs.GetInt("SmallSize"));
        player.SizeRalic = System.Convert.ToBoolean(PlayerPrefs.GetInt("SizeRalic"));
        player.PowerRlic = System.Convert.ToBoolean(PlayerPrefs.GetInt("PowerRlic"));

        Debug.Log("Load");
    }
}





