using System;
using System.Collections;
using System.Collections.Generic;
using GameFolders.Scripts.Concretes.Controllers;
using GameFolders.Scripts.Concretes.Pools;
using UnityEngine;

namespace GameFolders.Scripts.Concretes.Combats
{
    public class LaunchProjectile : MonoBehaviour
    {
        [SerializeField] private ProjectileController projectilePrefab;
        [SerializeField] private Transform projectileTransform;
        [SerializeField] private float delayProjectile = 1f;

        private float _currentDelayTime;
        private bool _canLaunch = false;

        private void Update()
        {
            _currentDelayTime += Time.deltaTime;

            if (_currentDelayTime > delayProjectile)
            {
                _canLaunch = true;
                _currentDelayTime = 0;
            }
        }

        public void LaunchAction()
        {
            if (_canLaunch)
            {
                ProjectileController poolObject = ProjectilePool.Instance.Get();
                poolObject.transform.position = projectileTransform.position;
                poolObject.gameObject.SetActive(true);

                _canLaunch = false;
            }
        }
    }
}

