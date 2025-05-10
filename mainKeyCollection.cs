using UnityEngine;
using UnityEngine.UI;
public class mainKeyCollection : MonoBehaviour
{
    public GameObject part1Key;
    public Image part1;

      [Header("Audio")]
    public AudioSource audiosource;
    public AudioClip mainKey1;

    void Start()
    {
        part1Key.SetActive(true);
        part1.gameObject.SetActive(false);
    }

       private void OnTriggerEnter(Collider other){
            if(other.gameObject.CompareTag("Player")){
                part1Key.SetActive(false);
                part1.gameObject.SetActive(true);
                 audiosource.clip = mainKey1;
                    audiosource.Play();
            }
    }
}
