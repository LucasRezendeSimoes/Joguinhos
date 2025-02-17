using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bot : MonoBehaviour
{
    private Rigidbody2D rb2d;
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var posBola = GameObject.Find("bolla").transform.position;
        var vel = rb2d.velocity;
        var atual = rb2d.position;

        if(Random.Range(0,4)>0 && posBola.x <= 0){
            rb2d.velocity = vel;
            transform.position =  Vector2.MoveTowards(transform.position, posBola, 0.002f);
        }
    }
}
