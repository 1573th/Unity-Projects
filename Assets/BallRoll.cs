using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.InputSystem;

public class BallRoll : MonoBehaviour
{
    public float force = 10f;
    private Rigidbody rb;
    private Vector3 startpos;
    void Start()
    {
        startpos = transform.position;
        rb = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.y < -10)
        {
            Respawn();
        }
        float x = 0f;
        float z = 0f;
        Keyboard kb = Keyboard.current;
        if (kb.aKey.isPressed) x = -1f;
        if (kb.dKey.isPressed) x = 1f;
        if (kb.sKey.isPressed) z = -1f;
        if (kb.wKey.isPressed) z = 1f;

        Vector3 direction = new Vector3(x, 0f, z).normalized;

        rb.AddForce(direction * force);
    }

    void Respawn() {
        transform.position = startpos;
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }
}
