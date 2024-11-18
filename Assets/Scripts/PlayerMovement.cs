using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rb;
    [SerializeField] private float _speed = 5f;
    private Vector2 _movement;
    private Vector2 _currentMove;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _movement = new Vector2(Input.GetAxisRaw("Horizontal"),0f);
    }


    private void FixedUpdate()
    {
        if(_movement.magnitude > 0)
        {
            
            _rb.velocity = _movement * _speed;
        }
        else
        {
            _currentMove = Vector2.zero;
            _rb.velocity = _currentMove;
        }
    }
}
