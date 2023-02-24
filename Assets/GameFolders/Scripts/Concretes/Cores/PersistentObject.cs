using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameFolders.Scripts.Concretes.Cores
{
    public class PersistentObject : MonoBehaviour
    {
        [SerializeField] private GameObject persistentPrefab;

        private static bool _isFirstTime = true;
        private void Start()
        {
            if (_isFirstTime)
            {
                SpawnPersistentObjects();

                _isFirstTime = false;
            }
        }

        private void SpawnPersistentObjects()
        {
            GameObject newObject = Instantiate(persistentPrefab);
            DontDestroyOnLoad(newObject);
        }
    }
}
