using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotPlayer : MonoBehaviour
{
    public float speed = 5f;
    public float tempLife;
    private Rigidbody2D rig;

    private Transform PlayerTransform;
    
    // Start is called before the first frame update
    void Start()
    {
        PlayerTransform = Player.instance.transform;
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        AimPlayer();
        transform.Translate(  speed * Time.deltaTime * Vector3.right);
        if (tempLife <= 0)
        {
            Destroy(gameObject);
        }
    }

    void AimPlayer()
    {
        Vector3 ShootingDirection =  PlayerTransform.position = transform.position;
        float AngleShot = Mathf.Atan2(ShootingDirection.y, ShootingDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, AngleShot );
    }
}
