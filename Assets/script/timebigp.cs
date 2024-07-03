using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timebigp : MonoBehaviour
{
    
    GameObject timerd = default;
    // Start is called before the first frame update
    void Start()
    {
        timerd = GameObject.Find("time"); 
    }

    // Update is called once per frame
    void Update()
    {
        
        timerd.GetComponent<Text>().text = Time.time.ToString("F2");
    }
}
