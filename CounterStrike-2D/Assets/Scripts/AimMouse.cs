using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimMouse : MonoBehaviour
{
    private Vector3 mousePosition;
    public GameObject Bullet;
    public Transform instantiateBullet;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = transform.position.z;
        
        LookAtMouse();
        Shoot();
    }
    
    private void Shoot()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(Bullet, instantiateBullet.position, transform.rotation);
        }
    }
    void LookAtMouse()
    {
        Vector3 lookDirection = mousePosition - transform.position;
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
