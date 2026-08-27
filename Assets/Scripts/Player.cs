using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float forcePower;

    [SerializeField]
    private Rigidbody rb;

    private InputAction moveAction;
    private Vector2 moveValue;

    [SerializeField]
    private int point;
    public int Point { get { return point; } set { point = value; } }

    [SerializeField]
    private int hp ;
    public int HP { get { return hp; } set { hp = value; } }

    [SerializeField]
    private float invincibleDuration = 0.5f; 
    private bool isInvincible = false;

    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        MoveLeftOrRight();
    }

    private void MoveLeftOrRight()
    {
        moveValue = moveAction.ReadValue<Vector2>();
        rb.AddForce(Vector3.right * moveValue.x * forcePower);
    }

    public bool CanTakeDamage()
    {
        return !isInvincible;
    }

    public void TakeDamageCooldown()
    {
        StartCoroutine(InvincibleCoroutine());
    }

    private System.Collections.IEnumerator InvincibleCoroutine()
    {
        isInvincible = true;
        yield return new WaitForSeconds(invincibleDuration);
        isInvincible = false;
    }


    //public bool CanTakeDamage()
    //{
    //    return !isInvincible;
    //}

    //public void TakeDamageCooldown()
    //{
    //    StartCoroutine(InvincibleCoroutine());
    //}

    //private System.Collections.IEnumerator InvincibleCoroutine()
    //{
    //    isInvincible = true;
    //    yield return new WaitForSeconds(invincibleDuration);
    //    isInvincible = false;
    //}
}