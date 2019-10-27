using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScripts : MonoBehaviour
{
    [SerializeField]
    private WeaponsScripts[] weaponss;

    private void Start()
    {
        Destroy(gameObject, 6);
    }

    private void Awake()
    {
        weaponss = GetComponentsInChildren<WeaponsScripts>();
    }

    void Update()
    {

        foreach (WeaponsScripts weapons in weaponss)
            if(weapons!=null && weapons.CanAttack)
            {
                weapons.Attack(true);
            }
    }
}
