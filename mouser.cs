using UnityEngine;

public class mouser : MonoBehaviour
{
    public GameObject m;
    public float speed = 2f; 
    public float maxDistance = 5f;

    private Vector3 startPos;
    private float distanceTraveled;
    private bool right;
        [Header("Audio")]
    public AudioSource audiosource;
    public AudioClip mousie;
    void Start()
    {
        startPos = transform.position; 
        distanceTraveled = 0f; 
    }

    void Update()
    {
  
        float pingPong = Mathf.PingPong(Time.time * speed, maxDistance);

    
        transform.position = new Vector3(startPos.x - pingPong, transform.position.y, transform.position.z);

        if(distanceTraveled >= maxDistance){
            right = !right;
            distanceTraveled = 0f;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            audiosource.clip = mousie;
            audiosource.Play();
         
        }
    }
}
