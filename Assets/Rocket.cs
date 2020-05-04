using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    [SerializeField] AudioClip thrustClip;

    AudioSource audioSorce;
    Renderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        audioSorce = GetComponent<AudioSource>();
        renderer = GetComponentInChildren<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Thrust(float strength)
    {
        renderer.material.color = Color.red * strength;
        if (strength > 0.01f)
        {
            if (!audioSorce.isPlaying)
            {
                audioSorce.PlayOneShot(thrustClip);
            }
        }
        else
        {
            audioSorce.Stop();
        }
    }
}
