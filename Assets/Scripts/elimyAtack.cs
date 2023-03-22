using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elimyAtack : MonoBehaviour
{

    playerHelth target;
    [SerializeField] float damage = 40f;
    void Start()
    {
        target = FindObjectOfType<playerHelth>();
    }

    public void AttackHitEvent()
    {

        if (target == null) return;

        target.TakeDamage(damage);
        Debug.Log("Bang Bang");
    }
}
