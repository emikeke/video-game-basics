using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // References the Rigidbody component "rb";
    public Rigidbody rb;

    public float forwardForce = 200f;

    // Update is called once per frame

    void FixedUpdate()
    {
        // Adds force to player cube
        rb.AddForce(Input.GetAxis("Horizontal") * forwardForce * Time.deltaTime, 0, 0);
        rb.AddForce(0, 0, Input.GetAxis("Vertical") * forwardForce * Time.deltaTime);
        if (rb.position.y < -1f) {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
