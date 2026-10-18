using UnityEngine;
using UnityEngine.InputSystem;

public class HandAnimator : MonoBehaviour
{
    public InputActionProperty triggerAnimation; 
    public InputActionProperty grabAnimation;  

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float triggerValue = triggerAnimation.action.ReadValue<float>();
        animator.SetFloat("Trigger", triggerValue);

        float gripValue = grabAnimation.action.ReadValue<float>();
        animator.SetFloat("Grab", gripValue);
    }
}