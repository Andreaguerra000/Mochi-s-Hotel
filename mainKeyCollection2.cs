using UnityEngine;
using UnityEngine.UI;
public class mainKeyCollection2 : MonoBehaviour
{
    public GameObject part2Key;
    public Image part1;
    public Image part2;

      [Header("Audio")]
    public AudioSource audiosource;
    public AudioClip mainKey1;

    void Start()
    {
        part2Key.SetActive(true);
        part1.gameObject.SetActive(true);
        part2.gameObject.SetActive(false);

    }

       private void OnTriggerEnter(Collider other){
            if(other.gameObject.CompareTag("Player")){
                part2Key.SetActive(false);
                part2.gameObject.SetActive(true);
                 audiosource.clip = mainKey1;
                    audiosource.Play();
            }
    }
}
