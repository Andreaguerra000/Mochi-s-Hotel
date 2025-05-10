using UnityEngine;
using UnityEngine.UI;
public class openDoor1stFloor : MonoBehaviour
{
    public GameObject doorK;
    public GameObject usedKey;
    public GameObject doorToOpen;
    public bool haskey = false;
   
    void Update()
    {
        if(usedKey == null){
                  Debug.Log("key has been destroyed");
            haskey = true;
        }
        
         if(Input.GetMouseButtonDown(0)){
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
                if(Physics.Raycast(ray, out hit)){
                    Debug.Log("hit something");
                    if(hit.collider.gameObject == gameObject){
                        if(haskey){
                        Debug.Log("door knob clicked");
                        doorToOpen.SetActive(false);
                        doorK.SetActive(false);
                        }
                        else{
                            Debug.Log("you need a key");
                        }
                    }
                }
          }
        
    }
}
