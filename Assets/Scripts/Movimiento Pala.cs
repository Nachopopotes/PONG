using UnityEngine;
using UnityEngine.InputSystem;

public class MovimientoPala : MonoBehaviour
{
    public float speed = 10;
    public enum JUGADOR { A, B };
    public JUGADOR jugador;

    void Update()
    {
        Vector3 dir = new Vector3(0, 0);

        if (jugador == JUGADOR.A)
        {
            if (Keyboard.current.wKey.IsPressed())
            {
                dir.y = 1;
            }
            if (Keyboard.current.sKey.IsPressed())
            {
                dir.y = -1;
            }
        }
        else
        {
            if (Keyboard.current.upArrowKey.IsPressed())
            {
                dir.y = 1;
            }
            if (Keyboard.current.downArrowKey.IsPressed())
            {
                dir.y = -1;
            }
        }

            transform.position += dir * speed * Time.deltaTime;
    }
}
