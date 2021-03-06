﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner:MonoBehaviour
{
    [SerializeField]
    private List<GameObject> enemies;


    private List<GameObject> pool = new List<GameObject>();
    private float elapsed;
    void generatePoolObjects()
    {
        
        for (int i = 0; i < enemies.Count; i++)
        {
         
                GameObject ga = Instantiate(enemies[i], new Vector3(Random.Range(-4.0f, 4.0f), 0.0f, 1.0f), Quaternion.identity);

                ga.transform.localScale = new Vector3(1.0f , 1.0f, 1.0f);
                ga.SetActive(false);
                pool.Add(ga);

        }
    }
    void Awake()
    {

        generatePoolObjects();

    }

    void GetFirstDead()
    {
        while (true)
        {

            int index = Random.Range(0, pool.Count);
            if (!pool[index].activeInHierarchy)
            {

                pool[index].SetActive(true);
                pool[index].transform.position
                             = new Vector3(Random.Range(-4.0f, 4.0f), transform.position.y, 0);
                break;
            }
            else
            {
                index = Random.Range(0, pool.Count);
            }
        }
    }
    void Update()
    {
        elapsed += Time.deltaTime;
        if (elapsed >= 2f)
        {
            print("hello");
            elapsed = 0f;
            GetFirstDead();
        }
   
    }
   
}

