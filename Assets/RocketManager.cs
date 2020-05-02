using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketManager : MonoBehaviour
{
    [SerializeField] GameObject leftRocket;
    [SerializeField] GameObject rightRocket;
    [SerializeField] OvrAvatar localAvatar;

    bool rocketsEnabled = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool leftIndex = OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch);
        bool rightIndex = OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch);
        bool leftHand = OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.LTouch);
        bool rightHand = OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.RTouch);

        Debug.Log(leftIndex + ", " + rightIndex + ", " + leftHand + ", " + rightHand);
        //if (leftIndex && rightIndex && leftHand && rightHand)
        if (leftIndex)
        {
            Debug.Log("toggling rockets");
            rocketsEnabled = !rocketsEnabled;
        }

        leftRocket.SetActive(rocketsEnabled);
        rightRocket.SetActive(rocketsEnabled);
        //localAvatar.enabled = !rocketsEnabled;
    }

}
