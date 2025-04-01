using UnityEngine;
using System.Collections;
public class KeyCollection : MonoBehaviour
{
    public GameObject key;
    public GameObject door;
    void Start(){
        key.SetActive(true);
        door = GameObject.FindWithTag("Entrance");
    }

    //if the character picks up the key, they will be able to enter the hotel
   private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Player")){
            Destroy(key);
            Debug.Log("I have collected the key");
        }
    }

    void OnDestroy(){
        if(door != null){
            Debug.Log("door has been unlocked");
            door.GetComponent<Collider>().enabled = false;
        }
    }
}
