using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class wepomZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamra;
    [SerializeField] float ZoomOutFov = 60f;
    [SerializeField] float ZoomInFov = 20f;

    [SerializeField] float zoomOutSensuticity = 2.0f;
    [SerializeField] float zoomInSensuticity = 0.5f;
    [SerializeField] RigidbodyFirstPersonController fpsControler;

    bool zoomInToggle = false;
   


    void Start()
    {
       
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (!zoomInToggle)
            {
                ZoomIn();

            }
            else
            {
                ZoomOut();
            }
        }
    }
    private void OnDisable()
    {
        ZoomOut();
    }

    private void ZoomOut()
    {
        zoomInToggle = false;
        fpsCamra.fieldOfView = ZoomOutFov;

        fpsControler.mouseLook.XSensitivity = zoomOutSensuticity;
        fpsControler.mouseLook.YSensitivity = zoomOutSensuticity;
    }

    private void ZoomIn()
    {
        zoomInToggle = true;
        fpsCamra.fieldOfView = ZoomInFov;

        fpsControler.mouseLook.XSensitivity = zoomInSensuticity;
        fpsControler.mouseLook.YSensitivity = zoomInSensuticity;
    }
}
