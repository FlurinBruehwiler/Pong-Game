using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public bool isLeftPlayer;
    public float speed;
    private Rigidbody2D rb;
    private float direction;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isLeftPlayer){
            direction = Input.GetAxisRaw("Vertical_Left");
        }
        else{
            direction = Input.GetAxisRaw("Vertical_Right");
        }
    }

    void FixedUpdate(){
        rb.velocity = new Vector2(0, direction * speed);
    }
}
