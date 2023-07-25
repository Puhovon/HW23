using System;
using DefaultNamespace;
using UnityEngine;

public class Input : MonoBehaviour
{
    private Vector3 movement;
    private Movement script;
    private Animations _animations;
    
    private void Awake()
    {
        script = GetComponent<Movement>();
        _animations = GetComponent<Animations>();
    }

    private void Update()
    {
        float vertical = UnityEngine.Input.GetAxis("Vertical");
        float horizontal = UnityEngine.Input.GetAxis("Horizontal");

        movement = new Vector3(horizontal, 0, vertical);
        
        if(UnityEngine.Input.GetButton("Fire1"))
            _animations.Attack();
    }

    private void FixedUpdate()
    {
        script.Move(movement);
    }
}
