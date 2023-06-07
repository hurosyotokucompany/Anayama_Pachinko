using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Blocks : MonoBehaviour
{
    Rigidbody myRigidbody;
    public float speed=-5f;
    // 何かとぶつかった時に呼ばれるビルトインメソッド
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
        // myRigidbody = GetComponent<Rigidbody>();
        // myRigidbody.velocity = new Vector3(0f, -speed, 0f);
        // ゲームオブジェクトを削除するメソッド
        Destroy(gameObject);
    }}
}
