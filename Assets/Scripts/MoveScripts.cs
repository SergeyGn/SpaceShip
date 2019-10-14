using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScripts : MonoBehaviour
{
    [SerializeField]
    private Vector2 speed = new Vector2(10, 10); //this is speed
    
    public Vector2 direction = new Vector2(-1, 0);

    private Vector2 movement;
    void Update()
    {
        movement = new Vector2(speed.x * direction.x, speed.y * direction.y);
    }
    private void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = movement;
    }
}
