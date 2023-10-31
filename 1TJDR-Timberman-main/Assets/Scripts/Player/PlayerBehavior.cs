using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerBehavior : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        GameSystem.instance.inputManager.OnHit += TimberHit;
    }

    private void TimberHit()
    {
        animator.SetTrigger("pHit");
    }

    private void OnDestroy()
    {
        GameSystem.instance.inputManager.OnHit -= TimberHit;
    }
}
