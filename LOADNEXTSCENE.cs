using UnityEngine;
using UnityEngine.SceneManagement;
public class LOADNEXTSCENE : MonoBehaviour
{
    public GameObject load;
      public void OnTriggerEnter(Collider other){
            if(other.gameObject.CompareTag("Player")){
                SceneManager.LoadScene("FirstFloor");
            }
      }
}
