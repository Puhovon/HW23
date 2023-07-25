using System;
using DefaultNamespace;
using UnityEngine;

public class Animations : MonoBehaviour
{
   private Animator _animator;
   private Movement movement;
   
   private void Awake()
   {
      _animator = GetComponent<Animator>();
      movement = GetComponent<Movement>();
   }

   private void Update()
   {
      _animator.SetFloat("VelocityNoZ", movement.Velocity.magnitude);   
   }
   
   public void Attack()
   {
      _animator.SetTrigger("Attack");
   }
}
