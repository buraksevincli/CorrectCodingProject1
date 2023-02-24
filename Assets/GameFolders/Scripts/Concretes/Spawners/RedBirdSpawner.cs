using System.Collections;
using System.Collections.Generic;
using GameFolders.Scripts.Abstracts.Controllers;
using GameFolders.Scripts.Abstracts.Spawners;
using GameFolders.Scripts.Concretes.Controllers;
using GameFolders.Scripts.Concretes.Movements;
using GameFolders.Scripts.Concretes.Pools;
using UnityEngine;

namespace GameFolders.Scripts.Concretes.Spawners
{
    public class RedBirdSpawner : BaseSpawner
    {
        protected override void Spawn()
        {
            LifeCycleController poolObject = RedBirdPool.Instance.Get();
            poolObject.transform.position = this.transform.position;
            poolObject.gameObject.SetActive(true);
        }
    }
}

