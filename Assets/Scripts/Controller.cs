using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilWizardYonlendirmeKodu : MonoBehaviour
{
    Rigidbody2D rb;
    public float Speed;
    bool jump;
    public float jumpForce;
    float horizontal;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && jump == true)
        {
            rb.AddForce(new Vector2(0, jumpForce));
            jump = false;
        }
    }




    void FixedUpdate()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector3 (horizontal * Time.deltaTime * Speed, rb.velocity.y, 0);


    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            jump = true;
        }
    }





}