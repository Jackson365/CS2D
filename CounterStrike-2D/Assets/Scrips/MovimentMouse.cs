using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentMouse : MonoBehaviour
{
    private Vector3 mousePosition;
    
    // Update is called once per frame
    void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = transform.position.z;
        
        LookAtMouse();
    }

    void LookAtMouse()
    {
        Vector3 lookDirection = mousePosition - transform.position;
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
