using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{

    [Header("Jump setup")]
    // the key used to activate the push
    public KeyCode key = KeyCode.Space;
    // Start is called before the first frame update
    private bool canJump = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // �W�����v
        if (canJump
            && Input.GetKeyDown(key))
        {
            // ���ʉ�
            GetComponent<AudioSource>().Play();
           // Debug.Log("abc");

        }

    }
}
