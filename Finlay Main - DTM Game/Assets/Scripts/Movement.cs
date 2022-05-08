using UnityEngine;

public class Movement : MonoBehaviour
{
    //Declaring variables
    public float horizontalInput;
    public float speed = 10.0f;
    private Rigidbody2D playerRb;
    public float jumpForce;
    public float gravityModifier;
    public bool isOnGround = true;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        //Sets Controlls for player
        horizontalInput = Input.GetAxis("Horizontal");
        if (isOnGround)
            playerRb.AddForce(Vector2.right * horizontalInput * speed, ForceMode2D.Force);
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isOnGround = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isOnGround = true;
    }
}