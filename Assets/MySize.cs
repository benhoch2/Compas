using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySize : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Renderer renderer = GetComponent<Renderer>();
        Debug.Log(gameObject.name + " size is " + renderer.bounds.size);
    }
}
