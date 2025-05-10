using UnityEngine;

public class chest : MonoBehaviour
{
    public GameObject treasureChest;
    public GameObject powers;
    public GameObject p1;

    public GameObject secret;

       [Header("Audio")]
    public AudioSource audiosource;
    public AudioClip chectOpened;
   // public GameObject power1;
    void Start()
    {
        secret = GameObject.FindWithTag("secretDoor");
        powers.SetActive(false);
        p1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

          if(Input.GetMouseButtonDown(0)){
                if(Physics.Raycast(ray, out hit)){
                     if(hit.collider.gameObject == gameObject){
                        Debug.Log("Clicked the treasure chest");
                        audiosource.clip = chectOpened;
                        audiosource.Play();
                        powers.SetActive(true);
                        p1.SetActive(true);
                        Destroy(secret);
                    }
                }
          }
    }
}
