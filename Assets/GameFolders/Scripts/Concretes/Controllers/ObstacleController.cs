using System;
using System.Collections;
using System.Collections.Generic;
using GameFolders.Scripts.Abstracts.Controllers;
using GameFolders.Scripts.Concretes.Pools;
using UnityEngine;

namespace GameFolders.Scripts.Concretes.Controllers
{
    public class ObstacleController : LifeCycleController
    {
        public override void SetPoolObject()
        {
            _currentTime = 0;
            ObstaclePool.Instance.Set(this);
        }
    }
}

