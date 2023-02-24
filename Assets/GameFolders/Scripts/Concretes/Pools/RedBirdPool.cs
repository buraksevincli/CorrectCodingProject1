using System;
using System.Collections;
using System.Collections.Generic;
using GameFolders.Scripts.Abstracts.Controllers;
using GameFolders.Scripts.Abstracts.Pools;
using GameFolders.Scripts.Concretes.Controllers;
using UnityEngine;

namespace GameFolders.Scripts.Concretes.Pools
{
    public class RedBirdPool : GenericPool<RedBirdController>
    {
        public static RedBirdPool Instance { get; private set; }

        protected override void SingletonPattern()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }

        public override void ResetPoolObjects()
        {
            foreach (RedBirdController child in GetComponentsInChildren<RedBirdController>())
            {
                if (!child.gameObject.activeSelf) continue;
                
                child.SetPoolObject();
            }
        }
    }
}

