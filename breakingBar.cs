using UnityEngine;

public class breakingBar : MonoBehaviour
{
    public GameObject bar;

     [Header("Audio")]
    public AudioSource audiosource;
    public AudioClip metalAttack;
    private int hitTimes = 0;
    void Start()
    {
        bar.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
         if(Input.GetMouseButtonDown(0)){
                if(Physics.Raycast(ray, out hit)){
                    if(hit.collider.gameObject == gameObject){
                        hitTimes++;

                        audiosource.clip = metalAttack;
                        audiosource.Play();

                        if(hitTimes >= 3){
                            Debug.Log("hit!!!!!");
                            bar.SetActive(false);
                        }
                    }
                }
            }
    }
}
