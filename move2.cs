using UnityEngine;

public class move2 : MonoBehaviour
{
    public Vector3 moveLeft = Vector3.left;
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
        transform.position = start + moveLeft.normalized * movement;
    }
}
