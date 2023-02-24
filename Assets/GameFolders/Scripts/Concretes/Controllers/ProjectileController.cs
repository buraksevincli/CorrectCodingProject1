using GameFolders.Scripts.Abstracts.Controllers;
using GameFolders.Scripts.Concretes.Managers;
using GameFolders.Scripts.Concretes.Pools;
using UnityEngine;

namespace GameFolders.Scripts.Concretes.Controllers
{
    public class ProjectileController : LifeCycleController
    {
        public override void SetPoolObject()
        {
            _currentTime = 0;
            ProjectilePool.Instance.Set(this);
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.gameObject.CompareTag("Enemy"))
            {
                GameManager.Instance.IncreaseScore();
                _currentTime = 0;
                SetPoolObject();
            }
        }
    }
}

