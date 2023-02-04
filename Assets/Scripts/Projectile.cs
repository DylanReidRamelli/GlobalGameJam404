using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public GameObject projectile;
    public float projectilespeed = 100.0f;
    private Rigidbody rb;
    private GameObject projInst;
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

            float hori = Input.GetAxisRaw("Horizontal");
            float vert = Input.GetAxisRaw("Vertical");

            projInst = Instantiate(projectile, gameObject.transform.position, gameObject.transform.rotation);
            rb = projInst.GetComponent<Rigidbody>();

            Debug.Log("Vert"+ vert);
            Debug.Log("Hor" + hori);

            if (hori == 0 && vert == 0)
            {
                rb.AddForce(new Vector3(1.0f, 0.0f, 0.0f) * projectilespeed, ForceMode.Impulse);
            }
            else 
            {
                rb.AddForce(new Vector3(hori, 0.0f, vert) * projectilespeed, ForceMode.Impulse);
            }
            Destroy(projInst, 3.0f);
        }
        
    }

}
