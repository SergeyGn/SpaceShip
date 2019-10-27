using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointScripts : MonoBehaviour
{
    private float timer;

    [SerializeField]
    private Transform _spawn;

    [SerializeField]
    private Transform _menu;

    bool isStart = false;

    void Update()
    {
        if (isStart == true)
        {
            timer += Time.deltaTime;
            int time = (int)timer;
            GetComponent<Text>().text = $"Time: {time} s.";
        }
        //if (time >= 10) GetComponent<Text>().color = Color.red;
        ////for (time=1; ;time+=10)
        ////{
        ////    GetComponent<SpawnScripts>().spawnCoolDawn -= 1;
        ////}


    }
    
    public void Button_Start()
    {
        isStart = true;
 
        _spawn.GetComponent<SpawnScripts>().enabled = true;
       _menu.gameObject.SetActive(false);
    }
    public void Button_Quit()
    {
        Application.Quit();
    }
    public void Сomplexity_Easy()
    {
        _spawn.GetComponent<SpawnScripts>().spawnCoolDawn = 6f;
    }
    public void Сomplexity_Medium()
    {
        _spawn.GetComponent<SpawnScripts>().spawnCoolDawn = 3f;
    }
   public  void Сomplexity_Hard()
    {
        _spawn.GetComponent<SpawnScripts>().spawnCoolDawn = 1f;
    }

}
