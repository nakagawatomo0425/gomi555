using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoretime : MonoBehaviour
{
    [SerializeField] Text text;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        time = timebigp.time;
        text.text = "Cleartime"+time.ToString("F2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
