using UnityEditor.Rendering.LookDev;
using UnityEngine;
using UnityEngine.InputSystem;


public class Interact : MonoBehaviour
{
    public InteractInputAction interactionAction;
    private InputAction fire;
    public Animator animator;
    private GameManager gameManager;
    

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

    void Start() 
    {
        fire = InputSystem.actions.FindAction("Fire");

    }

    void Update()
    {
        if (fire.IsPressed())
        {
            animator.SetBool("IsPush", true);
            Debug.Log("Click");
        }
        else if (fire.WasReleasedThisFrame())
        {
            animator.SetBool("IsPush", false);
            Debug.Log("UnClick");
        }   
    }


}
