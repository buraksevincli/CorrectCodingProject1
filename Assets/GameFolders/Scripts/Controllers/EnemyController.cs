using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameFolders.Scripts.Controllers
{
    public class EnemyController : MonoBehaviour
    {
        [SerializeField] private float maxLifeTime = 5f;
        private float _currentTime;

        private void Update()
        {
            _currentTime += Time.deltaTime;

            if (_currentTime > maxLifeTime)
            {
                Destroy(this.gameObject);
                _currentTime = 0;
            }
        }
    }
}

