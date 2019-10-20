using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformsScript : MonoBehaviour
{
    [SerializeField]
    private Transform _platform1;
    [SerializeField]
    private Transform _platform2;
    private float _platformCooldown;
    private float spawnCoolDawn = 5;
    private float timer = 0;

    void Update()
    {

        timer += Time.deltaTime;
        if (timer >= spawnCoolDawn)
        {
            int numberPlatform = Random.Range(1, 2);
            switch (numberPlatform)
            {
                case 1:
                    Spawn(_platform1);
                    break;
                case 2:
                    Spawn(_platform2);
                    break;
            }


        }


    }
    void Spawn(Transform platform)
    {
        float scaleZnachenie = Random.Range(0.1f, 1);
        int position = Random.Range(-5, 5);
        var platformTransform = Instantiate(platform);
        platformTransform.GetComponent<ScrollingScripts>().SetSpeed(new Vector2(2*scaleZnachenie, 2*scaleZnachenie));
        platformTransform.localScale = new Vector3(transform.localScale.x * scaleZnachenie, transform.localScale.y * scaleZnachenie, 1);
        platformTransform.position = new Vector3(transform.position.x, transform.position.y + position, transform.position.z + position);
        timer = 0;
    }

}
