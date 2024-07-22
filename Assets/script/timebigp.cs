using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timebigp : MonoBehaviour
{
    public static float time = 0f;
    GameObject timerd = default;
    // Start is called before the first frame update
    void Start()
    {
        time = 0f;
        timerd = GameObject.Find("time"); 
    }

    public static float gettime()
    {
        return time;
    }
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        timerd.GetComponent<Text>().text = time.ToString("F2");
    }
}
