using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerScripts : MonoBehaviour
{
    [SerializeField]
    private Vector2 speed = new Vector2(50, 50);
    private Vector2 movement;
    Rigidbody2D rigidbody;
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float InputX = Input.GetAxis("Horizontal");
        float InputY = Input.GetAxis("Vertical");
        movement = new Vector2(speed.x * InputX, speed.y * InputY);
    }
    void FixedUpdate()
    {
        rigidbody.velocity = movement;
    }
}
