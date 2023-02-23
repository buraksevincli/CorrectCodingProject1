using System;
using System.Collections;
using System.Collections.Generic;
using GameFolders.Scripts.Controllers;
using UnityEngine;
using Random = UnityEngine.Random;

namespace GameFolders.Scripts.Spawners
{
    public class ObstacleSpawner : MonoBehaviour
    {
        [Range(0.5f,1.5f)]
        [SerializeField] private float maxSpawnTime;
        [Range(3f,5f)]
        [SerializeField] private float minSpawnTime;

        private float _currentTime;
        private float _spawnTime;

        [SerializeField] private EnemyController[] enemies;

        private void Start()
        {
            TimeReset();
        }

        private void Update()
        {
            _currentTime += Time.deltaTime;
            

            if (_currentTime > _spawnTime)
            {
                Spawn();
                TimeReset();
            }
        }

        private void Spawn()
        {
            int enemyIndex = Random.Range(0, enemies.Length);
            Instantiate(enemies[enemyIndex],this.transform);
        }

        private void TimeReset()
        {
            _currentTime = 0;
            _spawnTime = Random.Range(minSpawnTime, maxSpawnTime);
        }
    }
}

