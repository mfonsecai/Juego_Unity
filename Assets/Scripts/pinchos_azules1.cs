using UnityEngine;

public class BallSideMoveSmall : MonoBehaviour
{
    public float moveDistance = 1f;   // Movimiento lateral mínimo
    public float speed = 2f;

    private Vector3 startPosition;
    private float randomOffset;
    private float randomSpeed;

    void Start()
    {
        startPosition = transform.position;

        // Desfase distinto para cada bola
        randomOffset = Random.Range(0f, 10f);

        // Velocidad ligeramente distinta
        randomSpeed = speed + Random.Range(-0.5f, 0.5f);
    }

    void Update()
    {
        float newY = startPosition.y +
                     Mathf.Sin((Time.time + randomOffset) * randomSpeed) * moveDistance;

        transform.position = new Vector3(
            startPosition.x,
            newY,
            startPosition.z
        );
    }
}