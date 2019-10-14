using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerScripts : MonoBehaviour
{
    [SerializeField]
    private Vector2 speed = new Vector2(50, 50);
    private Vector2 movement;
    Rigidbody2D rigidbody1;
    private void Start()
    {
        rigidbody1 = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float InputX = Input.GetAxis("Horizontal");
        float InputY = Input.GetAxis("Vertical");
        movement = new Vector2(speed.x * InputX, speed.y * InputY);
        bool isShot = Input.GetButtonDown("Fire1");
        isShot |= Input.GetButtonDown("Fire2");
        if (isShot)
        {
            WeaponsScripts weapons = GetComponent<WeaponsScripts>();
            if (weapons!=null)
            {
                weapons.Attack(false);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        bool isDamagePlayer = false;
        EnemyScripts enemy = collision.gameObject.GetComponent<EnemyScripts>();
        if (enemy!=null)
        {
            HealthShotScripts enemyHealth = enemy.GetComponent<HealthShotScripts>();

            if (enemyHealth != null) enemyHealth.Damage(enemyHealth.hp);
            isDamagePlayer = true;

        }
        if(isDamagePlayer)
        {
            HealthShotScripts playerHealth = this.GetComponent<HealthShotScripts>();
            if (playerHealth != null) playerHealth.Damage(1);
        }
    }
    void FixedUpdate()
    {
        rigidbody1.velocity = movement;
    }
}
