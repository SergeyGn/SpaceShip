using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScripts : MonoBehaviour
{
    [SerializeField]
    private Vector2 speed = new Vector2(10, 10); //this is speed
    [SerializeField]
    private Vector2 direction = new Vector2(-1, 0);
    private Vector2 movement;
    Rigidbody2D rigidbody;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        movement = new Vector2(speed.x * direction.x, speed.y*direction.y); 
    }
    private void FixedUpdate()
    {
        rigidbody.velocity = movement;
    }
}
