﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenSpawner : MonoBehaviour
{
    public GameObject chicken;
    public float interval = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObj", 0.1f, interval);
    }

    // Update is called once per frame
    void Update()
    {
        if (false == GameObject.FindGameObjectWithTag("GameMannager").GetComponent<GameMannager>().GetPlayerLive())
        {
            CancelInvoke("SpawnObj");
        }
    }

    void SpawnObj()
    {
        float randomY = Random.Range(-5f, 5f);
        Instantiate(chicken, new Vector2(24f, randomY),Quaternion.identity);
    }
}
