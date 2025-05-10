using UnityEngine;
using UnityEngine.SceneManagement;
public class button4 : MonoBehaviour
{

    public GameObject fourth;
    public GameObject lastKey;
    public bool hasKey = false;
     void Update(){

        if(!hasKey && lastKey == null){
            Debug.Log("key has been destroyed");
            hasKey = true;
        }

         if(Input.GetMouseButtonDown(0)){
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
                if(Physics.Raycast(ray, out hit)){
                if(hit.collider.gameObject == gameObject){
                    Debug.Log("hit something");
                     SceneManager.LoadScene("YouWin");
                }
                }
          }
    }
}
