using System.Collections;
using System.Collections.Generic;
using GameFolders.Scripts.Abstracts.Pools;
using GameFolders.Scripts.Concretes.Controllers;
using UnityEngine;

namespace GameFolders.Scripts.Concretes.Pools
{
    public class ProjectilePool : GenericPool<ProjectileController>
    {
        public static ProjectilePool Instance { get; private set; }
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
            foreach (ProjectileController child in GetComponentsInChildren<ProjectileController>())
            {
                if(!child.gameObject.activeSelf) continue;
                
                child.SetPoolObject();
            }
        }
    }
}

