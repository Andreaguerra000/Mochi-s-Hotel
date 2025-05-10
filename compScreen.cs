using UnityEngine;
using UnityEngine.UI;
public class compScreen : MonoBehaviour
{
    public GameObject computer;
    public GameObject screenn;
    public GameObject doorThree;
    public Button exitButton;
      
      [Header("Audio")]
    public AudioSource audiosource;
    public AudioClip screen;

    void Start()
    {
        if(exitButton != null){
            exitButton.onClick.AddListener(OnMyButtonClick);
        }
        screenn.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

          if(Input.GetMouseButtonDown(0)){
                if(Physics.Raycast(ray, out hit)){
                     if(hit.collider.gameObject == gameObject){
                        Debug.Log("Clicked the computer");
                        audiosource.clip = screen;
                        audiosource.Play();
                        screenn.SetActive(true);
                        doorThree.SetActive(false);
                    }
                }
          }
    }
     public void OnMyButtonClick(){
        Debug.Log("button is clicked");
        screenn.SetActive(false);
    }
}
