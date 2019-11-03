using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScripts : MonoBehaviour
{
    bool isInstantiate = false;
      void Update()
    {
    
       if(!isInstantiate && transform.position.x<=-0.59)
        {
            
            var next = Instantiate(gameObject);
            next.transform.position = new Vector3(21.67f, -1.67f, 10f);
            isInstantiate = true;
        }
        if (transform.position.x <= -20.58) Destroy(gameObject);

    }
}
