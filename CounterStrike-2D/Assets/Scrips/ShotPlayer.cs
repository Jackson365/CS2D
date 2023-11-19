using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotPlayer : MonoBehaviour
{
    public float shotSpeed = 8f;

    public Transform player;
    private Rigidbody2D body;
    
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        Destroy();
    }

    void FixedUpdate()
    {
        body.velocity = (Vector2)player.position * shotSpeed;
        body.velocity = (Vector2)player.position * shotSpeed;
    }

    private void Destroy()
    {
        Destroy(gameObject,2f);
    }
}
