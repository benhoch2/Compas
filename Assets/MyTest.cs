using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Renderer renderer = GetComponent<Renderer>();
        Debug.Log("compas size = " + renderer.bounds.size);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
