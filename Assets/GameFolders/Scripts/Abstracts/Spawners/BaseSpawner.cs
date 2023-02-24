using System.Collections;
using System.Collections.Generic;
using GameFolders.Scripts.Concretes.Controllers;
using UnityEngine;

namespace GameFolders.Scripts.Abstracts.Spawners
{
    public abstract class BaseSpawner : MonoBehaviour
    {
        [Range(0.5f,1.5f)]
        [SerializeField] private float maxSpawnTime;
        [Range(3f,5f)]
        [SerializeField] private float minSpawnTime;

        private float _currentTime;
        private float _spawnTime;

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

        protected abstract void Spawn();

        private void TimeReset()
        {
            _currentTime = 0;
            _spawnTime = Random.Range(minSpawnTime, maxSpawnTime);
        }
    }
}

