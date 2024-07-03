using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class astdl : MonoBehaviour
{
    float x;
    float y;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        x = transform.position.x; 
        y = transform.position.y;
        if (x > -33 || y < 122)
        {
            Destroy(this.gameObject);
        }
    }
    
}
