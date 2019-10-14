using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotScripts : MonoBehaviour
{
    
    public int damage = 1;
    public bool isEnemyShot = false;
    private void Start()
    {
        Destroy(gameObject, 5);
    }
    void Update()
    {
        
    }
}
