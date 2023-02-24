using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameFolders.Scripts.Abstracts.Controllers
{
    public abstract class LifeCycleController : MonoBehaviour
    {
        [SerializeField] private float maxLifeTime = 5f;

        protected float _currentTime;

        private void Update()
        {
            _currentTime += Time.deltaTime;

            if (_currentTime > maxLifeTime)
            {
                _currentTime = 0;
                SetPoolObject();
            }
        }

        public abstract void SetPoolObject();
    }
}

