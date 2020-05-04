using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(gameObject.name + " is at position " + transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObject.name + " is at position " + transform.position);
    }
}
