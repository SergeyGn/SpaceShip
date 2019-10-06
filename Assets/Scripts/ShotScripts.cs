using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotScripts : MonoBehaviour
{
    [SerializeField]
    private int damage = 1;
    [SerializeField]
    private bool isEnemyShot = false;
    private void Start()
    {
        Destroy(gameObject, 5);
    }
    void Update()
    {
        
    }
}
