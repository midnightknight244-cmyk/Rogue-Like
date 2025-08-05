using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public PlayerStats playerStats;

    public Vector2 movement;
    public Animator animator;
    public Rigidbody2D rb;

    private InputAction movementAction;
    private InputAction DashAction;
    private InputAction Attack01Action;

    [SerializeField] private float regularSpeed = 5;
    [SerializeField] private float dashSpeedMultipler = 2;
    [SerializeField] private float speed;

    private void Start()
    {
        speed = regularSpeed;

        movementAction = InputSystem.actions.FindAction("Player/Move");
        DashAction = InputSystem.actions.FindAction("Player/Dash");
        Attack01Action = InputSystem.actions.FindAction("Player/Attack_01");

        DashAction.performed += DashPerformed;
        Attack01Action.performed += Attack01Performed;

        animator.SetBool("IsAtk01", false);
    }

    void Update()
    {
        if (playerStats.canMove == true)
        {
            movement = movementAction.ReadValue<Vector2>();
        }
        else if (playerStats.canMove == false)
        {
            StopMovement();
        }

        Animation();
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + speed * movement * Time.fixedDeltaTime);
    }

    private void Animation()
    {
        animator.SetFloat("MoveSpeed", movement.sqrMagnitude);
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
    }

    private void DashPerformed(InputAction.CallbackContext context)
    {
        Debug.Log("Dash");
        speed = regularSpeed * dashSpeedMultipler;

        StartCoroutine(WaitToEnDash());
    }

    private void EndDash()
    {
        speed = regularSpeed;
    }

    private IEnumerator WaitToEnDash()
    {
        yield return new WaitForSeconds(0.5f);

        EndDash();
    }

    private void Attack01Performed(InputAction.CallbackContext context)
    {
        Debug.Log("Attack_01");
        animator.SetBool("IsAtk01", true);

    }

    public void ResetAttackAnim()
    {
        animator.SetBool("IsAtk01", false);
        speed = regularSpeed;
    }

    public void StopMovement()
    {
        speed = 0;
    }
}
