using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    float xInicial, yInicial;

    //Movimiento
    public float walkSpeed;
    private float moveInput;
    public bool isGrounded;
    private Rigidbody2D rb;
    public LayerMask groundMask;
    public SpriteRenderer sr;
 

    //Salto

    public float jumpValue = 20f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        xInicial = transform.position.x;
        yInicial = transform.position.y;

    }

    void Update()
    {

        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveInput = Input.GetAxis("Horizontal");

        if (!Input.GetKey("space") && isGrounded)
        {
            rb.velocity = new Vector2(moveInput * walkSpeed, rb.velocity.y);
<<<<<<< HEAD
=======
           
>>>>>>> 4f44eb76397fe00725a4b4c032fcdfc10cbe51d5
        }

        isGrounded = Physics2D.OverlapBox(new Vector2(gameObject.transform.position.x, gameObject.transform.position.y - 0.5f),
            new Vector2(0.9f, 0.4f), 0f, groundMask);

        //Salto
        if(Input.GetKey("space") && isGrounded)
        {
            jumpValue += 20f * Time.deltaTime;
<<<<<<< HEAD
=======
            
>>>>>>> 4f44eb76397fe00725a4b4c032fcdfc10cbe51d5

        }
        /*
        if (Input.GetKeyDown("space") && isGrounded && canJump)
        {
            rb.velocity = new Vector2(0.0f, rb.velocity.y);
        }
        */
        if (jumpValue >= 20f && isGrounded)
        {
            float tempx = moveInput * walkSpeed;
            float tempy = jumpValue;
            rb.velocity = new Vector2(tempx, tempy);
            jumpValue = 10f;
        }

        if (Input.GetKeyUp("space") && isGrounded)
        {
            float tempx = moveInput * walkSpeed;
            float tempy = jumpValue;
            rb.velocity = new Vector2(tempx, tempy);
            jumpValue = 10f;
        }

    }


    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawCube(new Vector2(gameObject.transform.position.x, gameObject.transform.position.y - 0.5f), new Vector2(0.9f, 0.2f));
    }

    public void Recolocar()
    {
        transform.position = new Vector3(xInicial, yInicial, 0);
    }

}
