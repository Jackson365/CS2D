using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed;

    private float timeDestroy = 1.0f;
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * bulletSpeed);
        
        Invoke("DestroyObject", timeDestroy);
    }

    private void DestroyObject()
    {
        Destroy(gameObject);
    }
    

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
        
        if (other.gameObject.tag == "Parede")
        {   
            Destroy(gameObject);
        }
    }
}
