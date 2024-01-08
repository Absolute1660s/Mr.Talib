using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class EvilWizardYonlendirmeKodu : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    bool canJump;
    public float jumpForce;
    private Animator anim;
    bool characterRightFace = true;


    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            canJump = false;
        }



    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(horizontal * speed * Time.deltaTime, rb.velocity.y);
        if (horizontal == 0)
        {
            anim.SetBool("isRunning", false);
        }
        else
        {
            anim.SetBool("isRunning", true);
        }

        if(characterRightFace == false && horizontal > 0)
        {
            Turn();
        }
        else if (characterRightFace == true &&  horizontal < 0)
        {
            Turn();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            canJump = true;
        }
    }


    private void Turn()
    {
        characterRightFace = !characterRightFace;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;

    }
}