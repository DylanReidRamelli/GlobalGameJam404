using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public GameObject projectile;
    public float projectilespeed = 100.0f;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        projectile.name = "bone";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           GameObject projInst = Instantiate(projectile, gameObject.transform.position, gameObject.transform.rotation);

            //gameObject.transform.LookAt(gameObject.transform.position + rb.velocity);
            rb = projInst.GetComponent<Rigidbody>();
            rb.AddForce(new Vector3(1.0f,0.0f,0.0f) * projectilespeed, ForceMode.Impulse);
            Destroy(projInst, 1.0f);
        }
        
    }

}
