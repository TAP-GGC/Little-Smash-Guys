using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FlyBehavior : MonoBehaviour
{
    [SerializeField] private float _velocity = 1.5f;   //Float Speed
    [SerializeField] private float _rotationSpeed = 10f; //Pivot Speed downwards

    private Rigidbody2D _rb; //A type of hitbox

    private void Start(){
        _rb = GetComponent<Rigidbody2D>(); //When we start we get the hitbox associated with the plane
    }

    private void Update(){
        if (Mouse.current.leftButton.wasPressedThisFrame){  //If we click our mouse 
            _rb.velocity = Vector2.up * _velocity; //Our hitbox will move upwards
        }
    }
    private void FixedUpdate(){
        transform.rotation = Quaternion.Euler(0,0, _rb.velocity.y * _rotationSpeed); //If we fail to click we fall downwards in a slow trend
    }
}
