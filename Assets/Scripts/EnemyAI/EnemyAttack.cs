using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    // PlayerHealth target;
    [SerializeField] Transform target;
    [SerializeField] int damage = 40;

    void Start()
    {
        //target = FindObjectOfType<PlayerHealth>();
    }

    public void AttackHitEvent()
    {
        if (target == null) return;

        //target.Damage(damage);
      //  target.GetComponent<DisplayDamage>().ShowDamageImpact();
    }

}