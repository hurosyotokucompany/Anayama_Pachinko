using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f;
    Rigidbody myRigidbody;

    void Start()
    {
        // Rigidbodyにアクセスして変数に保持
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // 左右のキー入力により速度を変更する
        myRigidbody.velocity = new Vector3(Input.GetAxis("Horizontal") * speed, 0f, 0f);
    }
}
