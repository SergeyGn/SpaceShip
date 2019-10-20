using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingScripts : MonoBehaviour
{
    [SerializeField]
    private Vector2 _speed = new Vector2(2, 2);
    [SerializeField]
    private Vector2 _direction = new Vector2(-1, 0);
    [SerializeField]
    private bool _isLinkedCamera = false;
         
    void Update()
    {
        Vector3 movement = new Vector3(_speed.x * _direction.x, _speed.y * _direction.y,0);
        movement *= Time.deltaTime;
        transform.Translate(movement);

        if (_isLinkedCamera) Camera.main.transform.Translate(movement);

    }
    public void SetSpeed(Vector2 speed)
    {
        _speed = speed;
    }
}
