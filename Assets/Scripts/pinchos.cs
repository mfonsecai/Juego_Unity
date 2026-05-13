using UnityEngine;

public class SpikeMover : MonoBehaviour
{
    public float moveHeight = 1.5f;
    public float speed = 3f;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float y = Mathf.PingPong(Time.time * speed, moveHeight);
        transform.position = new Vector3(
            startPos.x,
            startPos.y + y,
            startPos.z
        );
    }
}