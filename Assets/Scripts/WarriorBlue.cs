using UnityEngine;

public class WarriorBlue : MonoBehaviour
{
    public float speed = 5;
    public Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // FixedUpdate is called 50x per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        rb.linearVelocity = new Vector2(horizontal, vertical) * speed;

        
    }
}
