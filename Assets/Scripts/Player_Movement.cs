using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float speed = 5.0f;

    public Vector3 direction;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        direction = Vector3.right;
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }



    void move()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        if (horizontal != 0 || vertical != 0)
        {
            direction = new Vector3(horizontal, 0.0f, vertical);
            transform.Translate(direction * speed * Time.deltaTime, Space.World);
        }
        //if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        //{
        //    float hori = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        //    transform.Translate(new Vector3(hori, 0f, 0f), Space.World);
        //}
        //if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        //{
        //    float vert = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;
        //    transform.Translate(new Vector3(0f, 0f, vert), Space.World);
        //}

    }
}
