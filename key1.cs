using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class key1 : MonoBehaviour
{

    public GameObject key;
    public Image keyInInventory;
     public GameObject doorK;
    public GameObject doorToOpen;
    public bool haskey = false;

   
    [Header("Audio")]
    public AudioSource audiosource;
    public AudioClip keyCollected;
     void Start(){
                key.SetActive(true);
                 keyInInventory.gameObject.SetActive(false);
        }
    private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Player")){
            keyInInventory.gameObject.SetActive(true);
            Destroy(key);
            haskey = true;
            audiosource.clip = keyCollected;
            audiosource.Play();

            Debug.Log("I have collected the key");
        }
    }
     void Update()
    {   
         if(Input.GetMouseButtonDown(0)){
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
                if(Physics.Raycast(ray, out hit)){
                    if(hit.collider.gameObject == doorK){
                        Debug.Log("hitdoorknob");
                        
                        if(haskey){
                        Debug.Log("door knob clicked");
                        doorToOpen.SetActive(false);
                        doorK.SetActive(false);
                        keyInInventory.gameObject.SetActive(false);
                        }
                        else{
                            Debug.Log("you need a key");
                        }
                    }
                }
          }
        
    }

}
