using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScripts : MonoBehaviour
{

    private float timer;

    public int recordTime;

    [SerializeField]
    private Transform _spawn;

    [SerializeField]
    private Transform _menu;

    static public bool isStart = false;




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
    public void Сomplexity_Hard()
    {
        _spawn.GetComponent<SpawnScripts>().spawnCoolDawn = 1f;
    }
}
