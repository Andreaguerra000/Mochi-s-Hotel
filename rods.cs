using UnityEngine;

public class rods : MonoBehaviour
    {

    public GameObject rodup;
    public GameObject rodDown;
    
     [Header("Audio")]
    public AudioSource audiosource;
    public AudioClip rodPulled;
    void Start()
    {
        //this will give the appearance that the lever is not turned on
        //once the player presses it, the elavtor will be ready to be used so that the user can continue onto the next floor
        rodDown.SetActive(false);
        rodup.SetActive(true);
    }

    void Update(){
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        //need to check input of mouse so that the raycast doesnt go crazy
            if(Input.GetMouseButtonDown(0)){
                if(Physics.Raycast(ray, out hit)){
                    if(hit.transform == transform){
                         audiosource.clip = rodPulled;
                            audiosource.Play();
                        Debug.Log("Clicked rod");
                        //using boolean to determine if rod is clicked
                        bool isUpActive = rodup.activeSelf;
                        rodup.SetActive(!isUpActive);
                        rodDown.SetActive(isUpActive);
                    }
                }
                }
            }
}
