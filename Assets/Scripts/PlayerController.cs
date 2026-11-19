using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float jumpPower, speed, acceleration, velocity;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        velocity = 0;

        if (Input.GetKey(KeyCode.D))
        {
            velocity = Mathf.Lerp(rb.linearVelocityX, -speed, Time.deltaTime * acceleration);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            velocity = Mathf.Lerp(rb.linearVelocityX, speed, Time.deltaTime * acceleration);
        }

        rb.angularVelocity = velocity;

        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(Vector2.up * jumpPower);
        }
    }
}
