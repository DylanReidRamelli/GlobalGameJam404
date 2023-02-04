using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }



    void move()
    {
        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            float hori = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
            transform.Translate(new Vector3(hori, 0f, 0f), Space.World);
        }
        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {
            float vert = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;
            transform.Translate(new Vector3(0f, 0f, vert), Space.World);
        }

    }
}
