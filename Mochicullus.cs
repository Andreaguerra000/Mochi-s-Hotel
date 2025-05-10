using UnityEngine;

using System.Collections;
public class Mochicullus : MonoBehaviour
{
    public float speed = 20f;
    public float rotationSpeed = 20f;
     private Rigidbody rb;
     private Vector3 jump;

     public float jumpForce = 2f;
     private bool isGrounded;

        [Header("Audio")]
        public AudioSource audiosource;
        public AudioClip cathit;

    void Start(){
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }
    void Update()
    {
        Vector3 move = Vector3.zero;
    //move mochi forward and backwards only
        if(Input.GetKey(KeyCode.W)){
        transform.Translate(Vector3.forward * speed * Time.deltaTime);  
        }
        if(Input.GetKey(KeyCode.S)){
            transform.Translate(-Vector3.forward * speed * Time.deltaTime);
        }

//rotate mochi
        if(Input.GetKey(KeyCode.A)){
            transform.Rotate(Vector3.up * -rotationSpeed * Time.deltaTime);
        }
         if(Input.GetKey(KeyCode.D)){
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }

        if(Input.GetKeyDown(KeyCode.Space) && isGrounded){
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
            Debug.Log("jump!");
        }
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
         if(Input.GetMouseButtonDown(0)){
                if(Physics.Raycast(ray, out hit, 300f)){
                    oppMovement enemy = hit.collider.GetComponent<oppMovement>();
                        enemy.damage(1f);
                        Debug.Log("enemy hit");
                        audiosource.clip = cathit;
                        audiosource.Play();
                }
            }
    }
     void OnTriggerEnter(Collider collision){
        if(collision.gameObject.CompareTag("Ground")){
                isGrounded = true;
        }
    }
    void OnTriggerExit(Collider collision){
        if(collision.gameObject.CompareTag("Ground")){
                isGrounded = false;
        }
    }
}
