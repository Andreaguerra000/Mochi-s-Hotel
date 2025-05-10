using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class KeyCollection : MonoBehaviour
{
    public GameObject key;
    public Image keyCollectedImage;
    public GameObject door;

      
      [Header("Audio")]
    public AudioSource audiosource;
    public AudioClip obtainedKey;
    void Start(){
        key.SetActive(true);
        keyCollectedImage.gameObject.SetActive(false);
        door = GameObject.FindWithTag("Entrance");
    }

    //if the character picks up the key, they will be able to enter the hotel
   private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Player")){
            keyCollectedImage.gameObject.SetActive(true);
            Destroy(key);
            audiosource.clip = obtainedKey;
            audiosource.Play();
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
