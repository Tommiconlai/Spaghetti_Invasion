using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    public Animator animator;

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
        if (Input.GetKey(KeyCode.W))
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
        if (Input.GetMouseButton(1))
        {
            animator.SetBool("Aiming", true);
        }
        else
            animator.SetBool("Aiming", false);
    }
}
