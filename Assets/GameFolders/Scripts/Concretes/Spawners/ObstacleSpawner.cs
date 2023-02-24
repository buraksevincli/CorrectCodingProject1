using System;
using System.Collections;
using System.Collections.Generic;
using GameFolders.Scripts.Abstracts.Controllers;
using GameFolders.Scripts.Abstracts.Spawners;
using GameFolders.Scripts.Concretes.Pools;
using UnityEngine;

namespace GameFolders.Scripts.Concretes.Spawners
{
    public class ObstacleSpawner : BaseSpawner
    {
        protected override void Spawn()
        {
            LifeCycleController poolObject = ObstaclePool.Instance.Get();
            poolObject.transform.position = this.transform.position;
            poolObject.gameObject.SetActive(true);
        }
    }
}

