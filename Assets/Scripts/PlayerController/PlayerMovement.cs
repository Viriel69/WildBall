using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WildBall.Inputs
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField, Range(0, 10)] private float speed = 2.0f;
        private Rigidbody playerRigidbody;
        private Vector3 movement;
        
        private void Awake()
        {
            playerRigidbody = GetComponent<Rigidbody>();
        }
       
        public void MoveCharacter(Vector3 movement)
        {
            playerRigidbody.AddForce(movement * speed);
        }
    }
}
