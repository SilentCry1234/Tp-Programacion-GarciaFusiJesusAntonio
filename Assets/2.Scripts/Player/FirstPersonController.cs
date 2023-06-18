using UnityEngine;
using UnityEngine.InputSystem;

public class FirstPersonController : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpHeight;
    [SerializeField] private Transform ground;
    [SerializeField] private Transform orientation; 
    [SerializeField] LayerMask groundMask;

    private MyInputs controls;
    private Vector2 move;
    private Vector3 _moveDirection;

    private float distanceToGround = 0.4f; 
    private bool isGrounded;

    private Rigidbody rb;

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        controls = new MyInputs();

        rb.freezeRotation = true;
    }

    void Update()
    {
        Jump();
    }

    private void FixedUpdate()
    {
        Movement();
    }

    private void Movement()
    {
        move = controls.Player.Move.ReadValue<Vector2>();

        _moveDirection = orientation.forward * move.y + orientation.right * move.x;

        rb.MovePosition(rb.position + Time.deltaTime * moveSpeed * _moveDirection);
    }

    private void Jump()
    {
        isGrounded = Physics.CheckSphere(ground.position, distanceToGround, groundMask);

        if (controls.Player.Jump.triggered && isGrounded)
        {
            rb.AddForce(new Vector3(0, jumpHeight, 0), ForceMode.Impulse);
        }
    }
}
