using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontalInput;
    private bool facingRight = true;


    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        //si es menor a 0 se da vuelta
        if (horizontalInput > 0 && !facingRight)
        {
            Flip();
        } // si es mayor a cero... da vuelta pal otro lado
        else if (horizontalInput < 0 && facingRight)
        {
            Flip();
        }

    }
    void Flip()
    {
        facingRight = !facingRight;

        // Invierte el eje X 
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}
