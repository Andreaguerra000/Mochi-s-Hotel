using UnityEngine;
using UnityEngine.UI;
public class mainKeyCollection3 : MonoBehaviour
{
    public GameObject part3Key;
    public Image part3;


      [Header("Audio")]
    public AudioSource audiosource;
    public AudioClip mainKey3;

    void Start()
    {
        part3Key.SetActive(true);
        part3.gameObject.SetActive(false);

    }

       private void OnTriggerEnter(Collider other){
            if(other.gameObject.CompareTag("Player")){
                part3Key.SetActive(true);
                part3.gameObject.SetActive(false);
                 audiosource.clip = mainKey3;
                    audiosource.Play();
            }
    }
}
