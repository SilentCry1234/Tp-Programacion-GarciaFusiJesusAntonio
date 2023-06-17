using UnityEngine;
using UnityEngine.InputSystem;

public class FirstPersonController : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpHeight;
    [SerializeField] private Transform ground;
    [SerializeField] LayerMask groundMask;

    private MyInputs controls;
    private Vector3 velocity;
    private float gravity = -9.81f;
    private Vector2 move;

    private float distanceToGround = 0.4f; 
    private bool isGrounded;

    private CharacterController chController;

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
        chController = GetComponent<CharacterController>();
        controls = new MyInputs();
    }

    void Update()
    {
        Gravity();
        Movement();
        Jump();
    }

    private void Gravity()
    {
        isGrounded = Physics.CheckSphere(ground.position, distanceToGround, groundMask); 

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        velocity.y += gravity * Time.deltaTime;   
        chController.Move(velocity * Time.deltaTime);
    }

    private void Movement()
    {
        move = controls.Player.Move.ReadValue<Vector2>(); 

        Vector3 movement = (move.y * transform.forward) + (move.x * transform.right);
        chController.Move(movement * moveSpeed * Time.deltaTime);
    }

    private void Jump()
    {
        if(controls.Player.Jump.triggered && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity); 
        }
    }
}
