using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthShotScripts : MonoBehaviour
{
    public int hp = 1;
    public bool isEnemy = true;

    public void Damage(int damageCount)
    {
        hp -= damageCount;
        if (hp <= 0)
        {
            Destroy(gameObject);
        }

    }
    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        ShotScripts shot = otherCollider.gameObject.GetComponent<ShotScripts>();

        if (shot != null)
        {
            if (shot.isEnemyShot != isEnemy)
            {

                Damage(shot.damage);
                Destroy(shot.gameObject);
            }
        }
    }
}    
