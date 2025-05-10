using UnityEngine;

public class ghost : MonoBehaviour
{   public float speed = 10f;
    private Vector3 move;
    public GameObject g;

    public float minX = -7f;
    public float maxX = 116f;
    public float minZ = -279f;
    public float maxZ = -155f;


    void Start()
    {
        setrandomdirection();
    }

void setrandomdirection(){
    int randomnum =  Random.Range(1,5);

    if(randomnum == 1){
        move = Vector3.forward;
    }
    if(randomnum == 2){
        move = Vector3.back;
    }
    if(randomnum == 3){
        move = Vector3.left;
    }
    if(randomnum == 4){
        move = Vector3.right;
    }

    Invoke("setrandomdirection", 1f);
}
    void Update()
    {
        transform.Translate(move * speed * Time.deltaTime);
        float clampedX = Mathf.Clamp(transform.position.x, minX, maxX);
        float clampedZ = Mathf.Clamp(transform.position.z, minZ, maxZ);

        transform.position = new Vector3(clampedX, transform.position.y, clampedZ);
    
    }
        private void OnTriggerEnter(Collider other){
           if(other.gameObject.tag == "Player"){
                Debug.Log("you have crashed into the ghost!");
           }
    }
   
}
