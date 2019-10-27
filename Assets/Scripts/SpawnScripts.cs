using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScripts : MonoBehaviour
{
    [SerializeField]
    private Transform _EnemyPrefab;
    private float _EnemyCooldown=5f;
    public float spawnCoolDawn=5f;
    private float timer=0;


    void Update()
    {
              
        if (_EnemyCooldown > 0)
        {
            _EnemyCooldown -= Time.deltaTime;
        }

        timer += Time.deltaTime;
        if (timer >= spawnCoolDawn)
        {
            int kolichestvo = Random.Range(1, 5);

            for (int i = 1; i <= kolichestvo; i++)
            {
                int position = Random.Range(-5, 5);
                var enemyTransform = Instantiate(_EnemyPrefab);
                    enemyTransform.position = new Vector3(transform.position.x, transform.position.y + position, transform.position.z);
                    timer = 0;
               
            }
        }      
        
    }
}
