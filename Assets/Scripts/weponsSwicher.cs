using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weponsSwicher : MonoBehaviour
{

    [SerializeField] int currectWepon;

    // Start is called before the first frame update
    void Start()
    {
        SetWeponActive();
    }

    // Update is called once per frame
    void Update()
    {
        int previosWeapon = currectWepon;
        ProcessKeyInput();
        ProcessScrollWeel();

        if (previosWeapon != currectWepon)
        {
            SetWeponActive();
        }
    }

    private void ProcessScrollWeel()
    {
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if (currectWepon >= transform.childCount-1)
            {
                currectWepon = 0;
            }
            else
            {
                currectWepon++;
            }
        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if (currectWepon <=0)
            {
              currectWepon = transform.childCount - 1;
            }
            else
            {
                currectWepon--;
            }
        }
    }

    private void ProcessKeyInput()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currectWepon = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currectWepon = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currectWepon = 2;
        }
    }

    private void SetWeponActive()
    {
        int weaponIndex = 0;

        foreach (Transform weapon in transform)
        {
            if (weaponIndex == currectWepon)
            {
                weapon.gameObject.SetActive(true);
            }
            else
            {
                weapon.gameObject.SetActive(false);
            }

            weaponIndex++;
        }
    }
}
