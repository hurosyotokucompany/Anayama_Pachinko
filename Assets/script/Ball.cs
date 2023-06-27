using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed=-10f;
    Rigidbody myRigidbody;

    void Start()
    {
           // Rigidbodyにアクセスして変数に保持しておく
        myRigidbody = GetComponent<Rigidbody>();
        // 右斜め45度に進む
        myRigidbody.velocity = new Vector3(speed, speed, 0f);
    }

    // Update is called once per frame
    void Update()
    {     

        
    }
}
