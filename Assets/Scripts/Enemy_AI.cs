using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movement : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //Detect collisions between the GameObjects with Colliders attached
    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "bone")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("Destroy enemy.");
            Destroy(this);
        }
    }
}
