using UnityEngine;

public class oppMovement : MonoBehaviour
{
    public float speed = 10f;
    public GameObject doorToDestroy;
    public float moveDistance = 2f;
    public float directionChange = 1f;
    public float lives = 10f;
    private Vector3 startPosition;
    private Vector3 moveDirection = Vector3.left;
    private float Timer;

    //fireball settings
    public GameObject fireBall;
    public Transform firepoint;
    public float fireTime = 3f;
    private float fireTimer;
    void Start()
    {
        startPosition = transform.position;
        RandomDirection();
        doorToDestroy.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        if(Timer >= directionChange){
            RandomDirection();
            Timer = 0f;
        }
       transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);
       fireTimer += Time.deltaTime;
        if(fireTimer >= fireTime){
            shootFireball();
            fireTimer = 0;
        }
    }

    void RandomDirection(){
        int choice = Random.Range(0, 3);
        if(choice == 0){
            moveDirection = Vector3.left;
        }
        else if(choice == 1){
            moveDirection = Vector3.forward;
        }
        else{
            moveDirection = -Vector3.forward;
        }
    }
    void shootFireball(){
        if(fireBall != null && firepoint != null){
            GameObject player = GameObject.FindWithTag("Player");
            Vector3 directionPlayer = (player.transform.position - firepoint.position).normalized;
            Quaternion look = Quaternion.LookRotation(directionPlayer);
            GameObject instance = Instantiate(fireBall, firepoint.position, look);
            Destroy(instance, 3f);
        }
    }
    public void damage(float damage){
        lives -= damage;
        if(lives <= 0){
            Destroy(gameObject);
            doorToDestroy.SetActive(false);
        }
    }
}
