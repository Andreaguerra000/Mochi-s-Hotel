using UnityEngine;
using UnityEngine.SceneManagement;
public class button2 : MonoBehaviour
{
    public GameObject floor2Button;
     [Header("Audio")]
    public AudioSource audiosource;
    public AudioClip buttontwo;
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        //button selection to transfer over to the second floor
            if(Input.GetMouseButtonDown(0)){
                if(Physics.Raycast(ray, out hit)){
                    if(hit.transform == transform){
                        audiosource.clip = buttontwo;
                        audiosource.Play();
                        SceneManager.LoadScene("secondFloor");
                    }
                }
            }
    }
}
