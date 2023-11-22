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
    
    private void OnTriggerEnter2d(Collider2D other)
    {
        Destroy(gameObject);
    }
}
