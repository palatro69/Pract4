using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public Animator anim;
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        bool moving = h != 0; // Si es distinto de 0, es true
        // Actualiza el parámetro Bool
        anim.SetBool("IsWalking", moving);
    }
}
