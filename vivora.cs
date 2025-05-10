using UnityEngine;

public class vivora : MonoBehaviour
{
    public GameObject snake;
    public GameObject scratchPower;
    public GameObject finalDoor;
     [Header("Audio")]
    public AudioSource audiosource;
    public AudioClip snakeHit;
    private int hitTimes = 0;
    void Start()
    {
        finalDoor.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
    if(scratchPower.activeSelf){
    
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
         if(Input.GetMouseButtonDown(0)){
                if(Physics.Raycast(ray, out hit)){
                    if(hit.collider.gameObject == gameObject){
                        hitTimes++;
                        audiosource.clip = snakeHit;
                        audiosource.Play();
                        if(hitTimes >= 3){
                            Destroy(snake);
                            Debug.Log("hit!!!!!");
                            finalDoor.SetActive(false);
                        }
                    }
                }
            }
          }
    }
}
