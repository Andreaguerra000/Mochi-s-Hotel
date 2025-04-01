using UnityEngine;
using UnityEditor;
using System.Collections;
public class Mochicullus : MonoBehaviour
{
    public float speed = 5f;
     private Rigidbody rb;
    void Start(){
        rb = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
        transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);  
        }
        if(Input.GetKey(KeyCode.A)){
            transform.Translate(Vector3.left * speed * Time.deltaTime, Space.Self);
        }
         if(Input.GetKey(KeyCode.D)){
            transform.Translate(Vector3.right * speed * Time.deltaTime, Space.Self);
        }
         if(Input.GetKey(KeyCode.S)){
            transform.Translate(Vector3.back * speed * Time.deltaTime, Space.Self);
        }

    }
}
