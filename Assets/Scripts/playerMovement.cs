using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    float playerHeight = 2f;

    [Header("Movement")]
    public float movementSpeed = 6f;
    public float movementMultiplier = 10f;
    [SerializeField] float airMultiplier = 0.4f;

    [Header("Jumping")]
    public float jumpForce = 5f;

    [Header("Keybinds")]
    [SerializeField] KeyCode jumpKey = KeyCode.Space;
    
    [Header("Drag")]
    float groundDrag = 6f;
    float airDrag = 0.08f;

    float horizontalMovement;
    float verticalMovement;

    bool isGrounded;

    Vector3 moveDirection;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, playerHeight / 2 + 0.1f);

        myInput();
        controlDrag();

        if(Input.GetKeyDown(jumpKey) && isGrounded)
        {
            jump();
        }    
    }

    void myInput()
    {
        horizontalMovement = Input.GetAxisRaw("Horizontal"); // Tecla D presionada, devuelve 1 - tecla A presionada, devuelve -1
        verticalMovement = Input.GetAxisRaw("Vertical");

        moveDirection = transform.forward * verticalMovement + transform.right * horizontalMovement; // Direccion relativa a la del jugador
    }

    void jump()
    {
        rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
    }

    void controlDrag()
    {
        if(isGrounded)
        {
            rb.drag = groundDrag;
        }
        else
        {
            rb.drag = airDrag;
        }
    }

    void FixedUpdate() // Usa la frecuencia del sistema de fisicas de Unity
    {
        movePlayer();
    }

    void movePlayer()
    {
        if(isGrounded)
        {
            rb.AddForce(moveDirection.normalized * movementSpeed * movementMultiplier, ForceMode.Acceleration);
        }
        else if(!isGrounded)
        {
            rb.AddForce(moveDirection.normalized * movementSpeed * movementMultiplier * airMultiplier, ForceMode.Acceleration);
        }
    }
}
