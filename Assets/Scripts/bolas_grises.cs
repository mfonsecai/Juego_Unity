using UnityEngine;

public class BallMoverRandom : MonoBehaviour
{
    public float moveHeight = 8f;      // Altura máxima
    public float speed = 3f;           // Velocidad base

    private Vector3 startPosition;
    private float randomOffset;
    private float randomSpeed;

    void Start()
    {
        startPosition = transform.position;

        // Cada bola inicia en distinto momento
        randomOffset = Random.Range(0f, 20f);

        // Cada bola tiene velocidad diferente
        randomSpeed = speed + Random.Range(-1.5f, 2f);
    }

    void Update()
    {
        // Movimiento vertical aleatorio y desordenado
        float newY = startPosition.y +
                     Mathf.Sin((Time.time + randomOffset) * randomSpeed) * moveHeight;

        transform.position = new Vector3(
            startPosition.x,
            newY,
            startPosition.z
        );
    }
}