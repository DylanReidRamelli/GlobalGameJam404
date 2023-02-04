using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeStretch : MonoBehaviour
{

    private Vector3 scalechange, positionchange;
    // Start is called before the first frame update
    void Start()
    {
        scalechange = new Vector3(0.0f, -0.01f, 0.0f);
        //positionchange = new Vector3(0.0f, -0.005f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.localScale += scalechange;
        if (gameObject.transform.localScale.y > 0.8f)
        {
            scalechange = -scalechange;
            
        } else if (gameObject.transform.localScale.y < 1.2f)
        {
            scalechange = scalechange;
        }
        
    }
}
