using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public bool isLeftPlayer;
    public float speed;
    private Rigidbody2D rb;

    public GameObject Collider_Top;
    public GameObject Collider_Bottom;

    private float movement;

    public float Boundary_Top;
    public float Boundary_Bottom;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isLeftPlayer){
            movement = Input.GetAxisRaw("Vertical_Left");
        }
        else{
            movement = Input.GetAxisRaw("Vertical_Right");
        }

        if (Collider_Top.transform.position.y < Boundary_Bottom)
        {
            if(movement == -1)
            {
                movement = 0;
            }
        }
        else if(Collider_Bottom.transform.position.y > Boundary_Top)
        {
            if (movement == 1)
            {
                movement = 0;
            }
        }
    }

    void FixedUpdate(){
        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }
}
