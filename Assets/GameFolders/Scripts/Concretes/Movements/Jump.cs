using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameFolders.Scripts.Concretes.Movements
{
    public class Jump : MonoBehaviour
    {
        [SerializeField] private float jumpForce;

        public void JumpAction(Rigidbody2D rigidbody2D)
        {
            rigidbody2D.velocity = Vector2.zero;
            rigidbody2D.AddForce(Vector2.up*jumpForce);
        }
    }
}

