using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class FlyingScript : MonoBehaviour
{
    [SerializeField] private float _velocity = 3f;
    [SerializeField] private float _rotationSpeed = 10f;

    private Rigidbody2D _rb;
    
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            _rb.velocity = Vector2.up * _velocity;
        }
    }
    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, _rb.velocity.y * _rotationSpeed); 
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.instance.GameOver();
    }
}
