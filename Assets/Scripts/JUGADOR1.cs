using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float velocidad = 5f;
    public float gravedad = -9.8f;

    private CharacterController controller;
    private Vector3 velocidadVertical;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Captura las flechas del teclado
        float horizontal = Input.GetAxis("Horizontal"); // izquierda/derecha
        float vertical = Input.GetAxis("Vertical");     // arriba/abajo

        // Dirección del movimiento
        Vector3 movimiento = transform.right * horizontal + transform.forward * vertical;

        // Aplica el movimiento
        controller.Move(movimiento * velocidad * Time.deltaTime);

        // Gravedad para que no flote
        velocidadVertical.y += gravedad * Time.deltaTime;
        controller.Move(velocidadVertical * Time.deltaTime);
    }
}       