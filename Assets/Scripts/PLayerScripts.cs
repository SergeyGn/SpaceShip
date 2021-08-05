using UnityEngine.SceneManagement;
using UnityEngine;

public class PLayerScripts : MonoBehaviour
{
    [SerializeField]
    private Vector2 speed = new Vector2(50, 50);
    private Vector2 movement;
    //private Vector2 upLeft;
    //private Vector2 downRight;

    //private Vector2 _pastPosition;

    Rigidbody2D rigidbody1;
    HealthShotScripts healthShot;
    private void Start()
    {
        rigidbody1 = GetComponent<Rigidbody2D>();

        healthShot = GetComponent<HealthShotScripts>();

        //upLeft = Camera.main.ScreenToWorldPoint(new Vector3(0f, Screen.height, 0f));
        //downRight = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f));
    }
    void Update()
    {
       float InputX = Input.GetAxis("Horizontal");
       float InputY = Input.GetAxis("Vertical");
        bool isShot = Input.GetButtonDown("Fire1");
        isShot |= Input.GetButtonDown("Fire2");

        //if (Input.touchCount > 0)
        //{
        //    Debug.Log("Touch");
        //    Touch touch = Input.GetTouch(0);
        //    if (touch.phase==TouchPhase.Moved)
        //    {
        //        Vector2 pos = touch.position;
        //        InputX = pos.x-_pastPosition.x;
        //        InputY =pos.y-_pastPosition.y;

        //        _pastPosition = pos;
        //    }
        //    else if(touch.phase == TouchPhase.Began)
        //    {
        //        Debug.Log($"position {touch.position}");
        //        _pastPosition = touch.position;
        //    }
                
        //}
        //else
        //{
        //    InputX = 0;
        //    InputY = 0;
        //}


        movement = new Vector2(speed.x * InputX, speed.y * InputY);

        //if (transform.position.y >= upLeft.y-0.6f) transform.position = new Vector2(transform.position.x,upLeft.y-0.6f);
        //if (transform.position.y <= downRight.y+0.6f) transform.position = new Vector2(transform.position.x, downRight.y+0.6f);
        //if (transform.position.x >= downRight.x-0.6f) transform.position = new Vector2(downRight.x-0.6f, transform.position.y);
        //if (transform.position.x <= upLeft.x+0.6f) transform.position = new Vector2(upLeft.x+0.6f, transform.position.y);
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
