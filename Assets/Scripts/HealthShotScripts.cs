using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class HealthShotScripts : MonoBehaviour
{
    public int hp = 1;
    public bool isEnemy = true;
    public bool isLife = true;
 
    [SerializeField]
    private ParticleSystem smokeEffect;

    void Start()
    {
        PLayerScripts ps = GetComponent<PLayerScripts>();
        if (ps != null)
            isEnemy = false;
        
    }

    void Update()
    {
        if (hp <= 0) isLife = false;
    }
    public void Damage(int damageCount)
    {
        hp -= damageCount;
        if (hp <= 0)
        {
            Instantiate(smokeEffect);
            var smoke = Instantiate(smokeEffect);
            smoke.transform.position = transform.position;
            Destroy(gameObject);
            if (hp <= 0)
            {
                isLife = false;
                if (isEnemy == false)
                {
                    GameScripts.isStart = false;
                    SceneManager.LoadScene("ShipScene");
                }
            }
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
