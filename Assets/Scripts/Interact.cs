using UnityEngine;
using UnityEngine.InputSystem;


public class Interact : MonoBehaviour
{
    public InteractInputAction interactionAction;
    private InputAction fire;
    public Animator animator;
    private bool is_Push;

    void Awake()
    {
        interactionAction = new InteractInputAction();
        animator = GetComponent<Animator>();
    }

    private void OnEnable() 
    {
        fire = interactionAction.Player.Fire;
        fire.Enable();
    }

    private void OnDisable()
    {
        fire.Disable();
    }

    void Update() 
    {
        
    }

    public void Click(InputAction.CallbackContext context)
    {
        if(context.started)
        {
            animator.SetBool("IsPush", true);
            Debug.Log("Click");
        }
        else if (context.performed)
        {
            animator.SetBool("IsPush", false);
            Debug.Log("Nigga");
        }

    }
}
