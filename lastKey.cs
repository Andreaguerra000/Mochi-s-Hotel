using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class lastKey : MonoBehaviour
{
    public GameObject lastK;
    public GameObject wall;
    public Image keyimage;
    
    [Header("Audio")]
    public AudioSource audiosource;
    public AudioClip lastKeyCollected;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lastK.SetActive(true);
        wall.SetActive(true);
        keyimage.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Player")){
            audiosource.clip = lastKeyCollected;
            audiosource.Play();
            lastK.SetActive(false);
            wall.SetActive(false);
            keyimage.gameObject.SetActive(true);
        }
    }

}
