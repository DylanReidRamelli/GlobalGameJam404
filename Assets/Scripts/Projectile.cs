using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public GameObject projectile;
    public float projectilespeed = 10.0f;
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

            GameObject bullet = Instantiate(projectile, gameObject.transform.position, Quaternion.identity) as GameObject;
            Rigidbody bulletRB = bullet.GetComponent<Rigidbody>();
            bulletRB.AddForce(Vector3.forward * projectilespeed);
            Destroy(bullet, 0.5f);
            //GameObject projInst = Instantiate(projectile, this.transform.position, this.transform.rotation);

            //Rigidbody2D projectileRB = projInst.GetComponent<Rigidbody2D>();
            //projectileRB.AddForce(this.transform.position * throwForce, ForceMode2D.Impulse);
        }
        
    }

}
