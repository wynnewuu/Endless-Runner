using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinHandler : MonoBehaviour
{
    public static GameObject CoinText;
    public static int coins = 0;

    void Start() {
        if (PlayerPrefs.GetInt("coinsTotal") == null || PlayerPrefs.GetInt("coinsTotal") == 0)
            PlayerPrefs.SetInt("coinsTotal", 0);
        
        if (CoinText == null)
            CoinText = GameObject.Find("CoinText");
    }

    // Update is called once per frame
    public static void updateCoins(int coins)
    {
        PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
        PlayerPrefs.SetInt("coinsSession", coins);


        CoinText.text = "Total Coins:  " + PlayerPrefs.GetInt("coinsTotal") + "\nCoins This Session: " + coins + "\nTotal Enemies Killed: " 
            + PlayerPrefs.GetInt("killsTotal") + "\nEnemies Killed This Session: " + PlayerPrefs.GetInt("killsSession");// KillCount.kills  ;


        print( PlayerPrefs.GetInt("coinsSession")); //set the total variable to the previously saved value
        PlayerPrefs.Save();
    }
}
