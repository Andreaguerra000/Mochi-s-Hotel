using UnityEngine;
using UnityEngine.SceneManagement;
public class buttonToFloor3 : MonoBehaviour
{
    public GameObject button3;

    public GameObject mainKeyCollected;
    public bool collected = false;

    // Update is called once per frame
    void Update()
    {
        if(!mainKeyCollected.activeSelf){
            collected = true;
        }
        if(collected){
         if(Input.GetMouseButtonDown(0)){
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
                if(Physics.Raycast(ray, out hit)){
                    if(hit.collider.gameObject == button3){
                        Debug.Log("third button clicked");
                          SceneManager.LoadScene("ThirdFloor");
                    }
                }
          }
        }
    }
}
