using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // References the Rigidbody component "rb";
    public Rigidbody rb;

    // Update is called once per frame
    // Adds force to player cube
    void FixedUpdate()
    {
        rb.AddForce(0, 0, 2000 * Time.deltaTime);
    }
}
