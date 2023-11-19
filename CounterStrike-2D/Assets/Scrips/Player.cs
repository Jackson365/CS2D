using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    
    private Rigidbody2D rig;
    private Animator anim;
    
    public Transform instantiateShot;
    public GameObject shot;

    private float horizontal;
    private float vertical;
    
    public static Player instance;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        AttackShot();
    }

    void Movement()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        anim.SetInteger("transition", 1);
    }
    
    private void FixedUpdate()
    {  
        rig.velocity = new Vector2(horizontal * speed, vertical * speed);
    }

    private void AttackShot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject Shot = Instantiate(shot, instantiateShot.position, instantiateShot.rotation);

            //if (transform.rotation.y == 0)
            //{
                //shot.GetComponent<ShotPlayer>();
            //}

            //if (transform.rotation.y == 180)
            //{
                //shot.GetComponent<ShotPlayer>();
            //}
        }
    }
}
