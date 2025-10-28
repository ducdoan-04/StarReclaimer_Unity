using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 6f;
    Rigidbody2D rb;
    Vector2 input;

    void Awake() => rb = GetComponent<Rigidbody2D>();

    void Update()
    {
        input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
    }

    void FixedUpdate()
    {
        rb.linearVelocity = input * moveSpeed;   // Unity 6 dùng linearVelocity
    }
}
