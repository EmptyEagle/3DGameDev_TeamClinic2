using UnityEngine;

public class AnimationTriggers : MonoBehaviour
{
    [SerializeField] Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator.SetBool("BoolIsWalking", false);
    }

    public void StartWalking()
    {
        animator.SetBool("BoolIsWalking", true);
    }

    public void StopWalking()
    {
        animator.SetBool("BoolIsWalking", false);
    }

    public void TriggerBlock()
    {
        animator.SetTrigger("TrBlock");
    }
}
