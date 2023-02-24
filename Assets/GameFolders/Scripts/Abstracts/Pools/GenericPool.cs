using System;
using System.Collections;
using System.Collections.Generic;
using GameFolders.Scripts.Concretes.Managers;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

namespace GameFolders.Scripts.Abstracts.Pools
{
    public abstract class GenericPool<T> : MonoBehaviour where T : Component
    {
        [SerializeField] private T[] prefabs;
        [SerializeField] private int countLoop = 5;

        private Queue<T> _poolPrefab = new Queue<T>();

        private void Awake()
        {
            SingletonPattern();
        }
        
        private void Start()
        {
            GameManager.Instance.SceneObjectReset += ResetPoolObjects;
            GrowPoolPrefab();
        }

        protected abstract void SingletonPattern();
        public abstract void ResetPoolObjects();
        
        private void GrowPoolPrefab()
        {
            for (int i = 0; i < countLoop; i++)
            {
                T poolPrefab = Instantiate(prefabs[Random.Range(0, prefabs.Length)]);
                poolPrefab.transform.parent = this.transform;
                poolPrefab.gameObject.SetActive(false);
                _poolPrefab.Enqueue(poolPrefab);
            }
        }

        public T Get()
        {
            if (_poolPrefab.Count == 0)
            {
                GrowPoolPrefab();
            }

            return _poolPrefab.Dequeue();
        }

        public void Set(T poolObject)
        {
            poolObject.gameObject.SetActive(false);
            _poolPrefab.Enqueue(poolObject);
        }
        
        private void OnDisable()
        {
            GameManager.Instance.SceneObjectReset -= ResetPoolObjects;
        }
    }
}

