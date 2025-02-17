using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonzinho : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D (Collision2D coll) {
        source.Play();
    }
}
