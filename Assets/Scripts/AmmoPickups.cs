using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickups : MonoBehaviour
{
    [SerializeField] int ammoAmount = 5;
    [SerializeField] AmmoType ammoType;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            FindObjectOfType<ammo>().IncreaseCurrentAmmo(ammoType, ammoAmount);
            Debug.Log("ammoColected");
            Destroy(gameObject);
        }
    }
}
