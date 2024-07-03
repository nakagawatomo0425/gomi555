using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cleatxt : MonoBehaviour
{
   
    // Start is called before the first frame update
    float x;
    float y;
    GameObject gamerr = default;
    void Start()
    {
        

        gamerr = GameObject.Find("cleatxt");
    }

    // Update is called once per frame
    void Update()
    {
        x = transform.position.x;
        y = transform.position.y;

        if (y < 140 && y > 130 && x < 200 && x > 190)
        {
            //Debug.Log("abc");
            Text GameclearText = gamerr.GetComponent<Text>();
            GameclearText.text = "Game Clear";
            Time.timeScale = 0;
        }
    }
}
