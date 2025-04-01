using UnityEngine;
using UnityEngine.SceneManagement; 
public class mouse : MonoBehaviour
{
    //variables
     public GameObject m;
    public float speed = 2f; 
    public float maxDistance = 5f;

    private Vector3 startPos;
    private float distanceTraveled;
    private bool left;

    void Start()
    {
        startPos = transform.position; 
        distanceTraveled = 0f; 
    }

    void Update()
    {
  
        float pingPong = Mathf.PingPong(Time.time * speed, maxDistance);
        transform.position = new Vector3(startPos.x + pingPong, transform.position.y, transform.position.z);

        if(distanceTraveled >= maxDistance){
            left = !left;
            distanceTraveled = 0f;
        }

    }
     private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Player")){
             SceneManager.LoadScene("FirstFloor");
        }
    }
}
