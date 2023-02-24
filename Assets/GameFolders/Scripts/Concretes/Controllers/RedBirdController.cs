using System;
using System.Collections;
using System.Collections.Generic;
using GameFolders.Scripts.Abstracts.Controllers;
using GameFolders.Scripts.Concretes.Pools;
using UnityEngine;

namespace GameFolders.Scripts.Concretes.Controllers
{
    public class RedBirdController : LifeCycleController
    {
        public override void SetPoolObject()
        {
            _currentTime = 0;
            RedBirdPool.Instance.Set(this);
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.gameObject.CompareTag("Projectile"))
            {
                _currentTime = 0;
                SetPoolObject();
            }
        }
    }
}

