using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControllerX : MonoBehaviour
{
    bool alive = true;
    public float speed;
    public Rigidbody rb;
    float horizonalInput;
    public float horizontalMultiplier = 2;

    public float jumpForce = 400f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   

    private void FixedUpdate()
    {
        if (!alive) return;
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizonalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
    }

    private void Update()
    {
        horizonalInput = Input.GetAxis("Horizontal");
        if (transform.position.y < -5)
        {
            Die();
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            Jump();
        }
    
    }

   

    public void Die()
    {
        alive = false;

        Invoke("Restart", 1);

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void Jump()
    {
        float height = GetComponent<Collider>().bounds.size.y;
        bool isGrounded = Physics.Raycast(transform.position, Vector3.down, height / 2 + 0.1f);

        rb.AddForce(Vector3.up * jumpForce);
    }

}
