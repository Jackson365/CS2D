using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMira : MonoBehaviour
{
    public float rotateSpeed = 5f;
    private Vector3 mousePos;
    private Vector3 direction;
    
    void Update()
    {
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        direction = new Vector3(mousePos.x - transform.position.x, mousePos.y - transform.position.y, 0);
        
        transform.up = direction;
    }
}
