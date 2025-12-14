using UnityEngine;

public class working : MonoBehaviour
{
    public float speed = 5f;      
    private Rigidbody2D rb;
    private Vector2 moveInput;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");  
        float y = Input.GetAxisRaw("Vertical");
        moveInput = new Vector2(x, y).normalized;
    }
    void FixedUpdate()
    {
        rb.velocity = moveInput * speed;
    }
}
