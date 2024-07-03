using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameov : MonoBehaviour
{
    HealthSystemAttribute _helthd;
    // Start is called before the first frame update
    float x;
    float y;
    GameObject gameof = default;
    void Start()
    {
        _helthd = GetComponent<HealthSystemAttribute>();
       
        gameof = GameObject.Find("gameovertxt");
    }

    // Update is called once per frame
    void Update()
    {
        x = transform.position.x;
        y = transform.position.y;

        if (y < -8 || y > 200 || x < -149 || x > 220)
        {
            //Debug.Log("abc");
            Text GameovreText = gameof.GetComponent<Text>();
            GameovreText.text = "Game Over";
            Time.timeScale = 0;
        }
    }
}
