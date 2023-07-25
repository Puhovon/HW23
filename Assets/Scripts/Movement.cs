using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class Movement : MonoBehaviour
    {
        [SerializeField] private float speed;

        private Rigidbody rb;

        public Vector3 Velocity => rb.velocity;
        private void Awake()
        {
            rb = GetComponent<Rigidbody>();
        }

        public void Move(Vector3 movement)
        {
            rb.velocity = movement * speed;
        }
    }
}