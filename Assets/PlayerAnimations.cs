using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        RunAnimation();
        ReloadAnimation();
        AimAnimation();
    }

    public void RunAnimation()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetBool("Running", true);
        }
        else
            animator.SetBool("Running", false);
    }

    public void ReloadAnimation()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            animator.SetTrigger("Reload");
        }
        else
            animator.ResetTrigger("Reload");
    }

    public void AimAnimation()
    {
        if (Input.GetMouseButtonDown(2))
        {
            animator.SetBool("Aiming", true);
        }
        else
            animator.SetBool("Aiming", false);
    }
}
