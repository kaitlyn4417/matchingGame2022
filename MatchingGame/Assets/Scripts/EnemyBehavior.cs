using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public MySO enemy;

    public string nameText;
    public int healthText;
    public int damageText;

    void Start()
    {
        nameText = enemy.name;
        healthText = enemy.health;
        damageText = enemy.damage;
    }
}
