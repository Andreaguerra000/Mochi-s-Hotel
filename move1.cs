using UnityEngine;

public class move1 : MonoBehaviour
{
    public Vector3 moveRight = Vector3.right;
    public float movingDistance = 5f;
    public float speed = 2f;

    private Vector3 start;
    void Start()
    {
        start = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float movement = Mathf.PingPong(Time.time * speed, movingDistance);
        transform.position = start + moveRight.normalized * movement;
    }
}
