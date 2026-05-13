using UnityEngine;

public class RollerMover : MonoBehaviour
{
    public float moveDistance = 10f; // Distancia mayor
    public float speed = 2f;         // Velocidad

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float movement = Mathf.Sin(Time.time * speed) * moveDistance;

        transform.position = new Vector3(
            startPos.x + movement,
            startPos.y,
            startPos.z
        );
    }
}