using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{

    private Rigidbody2D rb2D;
    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        rb2D.linearVelocity = new Vector2(x * speed, y * speed);

    }
}
