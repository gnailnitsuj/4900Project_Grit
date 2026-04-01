using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 8f;
    public float jump = 2f;
    public float gravity = -9.81f * 2; //Unity's default gravity value
    public CharacterController control;
    Vector3 velocity;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded;
    public Animator animations;
    public float sprintCost = 15f;
    public float blockCost = 10f;
    public float swingCost = 20f;
    public PlayerStats stats;

    void Start(){
        animations = GetComponent<Animator>();
    }

    
    void Update()
    {
        //Creates sphere below player to check ground contact
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if (isGrounded && velocity.y < 0) {
            velocity.y = -2f;
        }


        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        control.Move(move * speed * Time.deltaTime);


        if(Input.GetButtonDown("Jump") && isGrounded){
            velocity.y = Mathf.Sqrt(jump * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;
        control.Move(velocity * Time.deltaTime);

        //Animations + Mechanics
        if (Input.GetMouseButtonDown(0) && stats.currentSTAM > 0){
            animations.SetTrigger("Swing");
            stats.drainStam(swingCost);
        }
        if (Input.GetMouseButtonDown(1) && stats.currentSTAM > 0) {
            animations.SetTrigger("Block");
            stats.drainStam(blockCost);
        }

        //Sprint
        if (Input.GetKey("left shift") && stats.currentSTAM > 0) {
            speed = 12f;
            stats.drainStam(sprintCost * Time.deltaTime);
        } else {
            speed = 8f;
        }
    }
}
