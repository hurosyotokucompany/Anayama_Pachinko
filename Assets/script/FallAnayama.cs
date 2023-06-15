using UnityEngine;

public class FallAnayama : MonoBehaviour
{

    private void Start()
    {
        var rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            // RigidbodyのUse Gravityを有効にします。
            rb.useGravity = true;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Wall")){
            Destroy(gameObject);
        }
        Destroy(gameObject);
    }
}
