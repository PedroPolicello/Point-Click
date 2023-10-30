using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerBehaviour : MonoBehaviour
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
        //ToDo
        print("Hit!");
    }

    private void OnDestroy()
    {
        GameSystem.instance.inputManager.OnHit -= TimberHit;
    }
}
