using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    bool alive = true;

    public float speed = 5f;
    public Rigidbody rb;

    float horizontalInput;
    float horizontalMultiplier = 1.7f;

    public float speedIncreasePerPoint = 0.1f;

    private void FixedUpdate()
    {
        if (!alive) return;


        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
    }
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if (transform.position.y < -5)
        {
            end();
        }
    }

    public void end ()
    {
        alive = false;

        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }
}
