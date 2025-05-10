using UnityEngine;
using UnityEngine.SceneManagement;
public class LOADNEXTSCENE : MonoBehaviour
{

    //detects if the player wants to enter the first floor
    public GameObject load;
      public void OnTriggerEnter(Collider other){
            if(other.gameObject.CompareTag("Player")){
                SceneManager.LoadScene("FirstFloor");
            }
      }
}
