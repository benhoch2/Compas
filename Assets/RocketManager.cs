using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketManager : MonoBehaviour
{
    [SerializeField] GameObject leftRocket;
    [SerializeField] GameObject rightRocket;
    [SerializeField] OvrAvatar localAvatar;
    [SerializeField] Rigidbody rb;
    [SerializeField] float thrustFactor;
    [SerializeField] ForceMode thrustForceMode;

    bool leftIndex, rightIndex, leftHand, rightHand;
    float leftThrust, rightThrust;

    bool rocketsEnabled = false;
    bool canToggle = true;


    // Update is called once per frame
    void Update()
    {
        GetInput();
        ToggleRockets();
        if (rocketsEnabled)
        {
            UpdateRockets();
        }
        
    }

    private void UpdateRockets()
    {
        leftRocket.GetComponent<Rocket>().Thrust(leftThrust);
        rightRocket.GetComponent<Rocket>().Thrust(rightThrust);
    }

    private void FixedUpdate()
    {
        if (rocketsEnabled)
        {
            ApplyRocketForce();
        }

    }

    private void ApplyRocketForce()
    {
        //add force
        rb.AddForce(leftRocket.transform.forward * leftThrust * thrustFactor, thrustForceMode);
        rb.AddForce(leftRocket.transform.forward * rightThrust * thrustFactor, thrustForceMode);
    }

    private void ToggleRockets()
    {
        if (canToggle && leftIndex && rightIndex && leftHand && rightHand)
        {
            Debug.Log("toggling rockets");
            rocketsEnabled = !rocketsEnabled;
            canToggle = false;
            StartCoroutine(UnlockRockets());
        }

        leftRocket.SetActive(rocketsEnabled);
        rightRocket.SetActive(rocketsEnabled);
        //localAvatar.SetActive(!rocketsEnabled);
    }

    private void GetInput()
    {
        leftIndex = OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch);
        rightIndex = OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch);
        leftHand = OVRInput.Get(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.LTouch);
        rightHand = OVRInput.Get(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.RTouch);

        leftThrust = OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger, OVRInput.Controller.LTouch);
        rightThrust = OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger, OVRInput.Controller.RTouch);
    }

    private IEnumerator UnlockRockets()
    {
        yield return new WaitForSeconds(1f);
        canToggle = true;
        Debug.Log("unlock rockets");

    }
}
