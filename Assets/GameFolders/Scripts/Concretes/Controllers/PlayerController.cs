using GameFolders.Scripts.Concretes.Combats;
using GameFolders.Scripts.Concretes.Movements;
using UnityEngine;

namespace GameFolders.Scripts.Concretes.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        private Rigidbody2D _rigidbody2D;
        private Jump _jump;
        private PcInputController _pcInputController;
        private LaunchProjectile _launchProjectile;
        private Dead _dead;
        private AudioSource _audioSource;
        
        private bool _isJumped;

        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
            _jump = GetComponent<Jump>();
            _launchProjectile = GetComponent<LaunchProjectile>();
            _dead = GetComponent<Dead>();
            _audioSource = GetComponent<AudioSource>();
            _pcInputController = new PcInputController();
        }

        private void FixedUpdate()
        {
            if (_isJumped)
            {
                _jump.JumpAction(_rigidbody2D);
                _isJumped = false;
            }
        }

        private void Update()
        {
            if(_dead.IsDead) return;
            
            if (_pcInputController.LeftMouseClicked)
            {
                _audioSource.Play();
                _isJumped = true;
            }

            if (_pcInputController.RightMouseClicked)
            {
                _launchProjectile.LaunchAction();
            }
        }
    }
}

