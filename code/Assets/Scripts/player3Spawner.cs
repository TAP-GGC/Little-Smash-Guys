﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player3Spawner : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject knight;
    public GameObject archer;
    public GameObject viking;
    public GameObject wizard;
    public GameObject player3;
    private bool isMelee;
    // Start is called before the first frame update
    void Start()
    {
        findPlayer3();
    }

    public void findPlayer3()
    {
        
        if (playerValues.P3knight)
        {
            Destroy(player3);
            player3 = Instantiate(knight, spawnPoint);
            isMelee = true;

        }
        else if (playerValues.P3archer)
        {
            Destroy(player3);
            player3 = Instantiate(archer, spawnPoint);
            isMelee = false;
        }
        else if (playerValues.P3viking)
        {
            Destroy(player3);
            player3 = Instantiate(viking, spawnPoint);
            isMelee = true;
        }
        else if (playerValues.P3wizard)
        {
            Destroy(player3);
            player3 = Instantiate(wizard, spawnPoint);
            isMelee = false;
        }
        else
        {
            return;
        }

        player3.transform.gameObject.tag = "player3";
        player3.GetComponent<PlayerControl>().playerId = 2;
        //player3.GetComponent<PlayerControl>().horiztonal = "P3_Horizontal";
        //player3.GetComponent<PlayerControl>().jumpButton = "P3_Jump";
        player3.GetComponent<PlayerControl>().isMelee = isMelee;
        //player3.GetComponent<PlayerControl>().attack = "P3_Fire";
        player3.GetComponent<ChangeColor>().playerNumber = 3;
        player3.GetComponent<ActivatePlayerTag>().player = "player3";


    }
    public void DestroyPlayer()
    {
        Destroy(player3);
    }
}
