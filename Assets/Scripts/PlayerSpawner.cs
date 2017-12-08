﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour {

    public GameObject playerPrefab;
    GameObject playerInstance;

    public int numLives = 4;
    int score = 0;

    float respawnTimer;

    void Start() {
        SpawnPlayer();
    }

    void SpawnPlayer()
    {
        numLives--;
        respawnTimer = 1;

        //재생성시 초기 값
        playerInstance = (GameObject)Instantiate(playerPrefab, transform.position, Quaternion.identity);

    }

    void Update() {
        if (playerInstance == null && numLives > 0)
        {

            respawnTimer -= Time.deltaTime;

            if (respawnTimer <= 0)
            {
                SpawnPlayer();
            }
        }
    }

    void OnGUI()
    {
        if (numLives > 0 || playerInstance != null)
        {
            GUI.Label(new Rect(0, 0, 100, 50), "Lives Left: " + numLives);

        }
        else
        {
            GUI.Label(new Rect(Screen.width/2 -50,Screen.height/2 -25, 100, 50), "GAME OVER");

        }
        
        if(numLives > 0 || playerInstance != null)
        {
            GUI.Label(new Rect(Screen.width, Screen.height, 100, 50), "Score" + score);

        }
    }
}
