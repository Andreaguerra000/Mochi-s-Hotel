using UnityEngine;
using UnityEngine.UI;
public class map : MonoBehaviour
{
    public GameObject outsideMap;
    public Image pictureOfMap;


    public Button mapButton;
    public Button ExitMap;

    [Header("Audio")]
    public AudioSource audiosource;
    public AudioClip mapCollected;
    private bool CollectedMAP = false;
//displays map when clicked for outside area
    void Start(){
        mapButton.onClick.AddListener(opennedMap);
        ExitMap.onClick.AddListener(ExitingMap);

        pictureOfMap.gameObject.SetActive(false);
        mapButton.gameObject.SetActive(false);
        ExitMap.gameObject.SetActive(false);
        }

    void opennedMap(){
        if(CollectedMAP){
            pictureOfMap.gameObject.SetActive(true);
            mapButton.gameObject.SetActive(true);
            ExitMap.gameObject.SetActive(true);    
        }
    }
    void ExitingMap(){
        outsideMap.SetActive(false);
        ExitMap.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Player") && !CollectedMAP){
            CollectedMAP = true;
            audiosource.clip = mapCollected;
            audiosource.Play();

            outsideMap.SetActive(false);
            mapButton.gameObject.SetActive(true);
        }
    }
}
