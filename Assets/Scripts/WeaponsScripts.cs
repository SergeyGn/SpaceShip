using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsScripts : MonoBehaviour
{
    [SerializeField]
    private Transform _shotPrefab;

    [SerializeField]
    private float _shotingRate = 0.25f;

    private float _shotCooldown;

    public bool CanAttack
    {
        get
        {
            return _shotCooldown <= 0f;
        }
    }

    void Start()
    {
        _shotCooldown = 1f;
    }

    void Update()
    {
        if(_shotCooldown>0)
        {
            _shotCooldown -= Time.deltaTime;
        }
    }

    public void Attack(bool isEnemy)
    {
        if(CanAttack)
        {
            _shotCooldown = _shotingRate;

            var shotTransform = Instantiate(_shotPrefab) as Transform;
            shotTransform.position = transform.position;

            ShotScripts shot = shotTransform.gameObject.GetComponent<ShotScripts>();
            if(shot!=null)
            {
                shot.isEnemyShot = isEnemy;

            }
            MoveScripts move = shotTransform.gameObject.GetComponent<MoveScripts>();
            if (move != null)
                move.direction = this.transform.right;
            
        }
    }
}
