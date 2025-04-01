using UnityEngine;
using UnityEngine.SceneManagement;
public class BackToMAIN : MonoBehaviour
{
      /*
      this function checks to see if player wants to go back outside to the main area
      */
   public GameObject backToMain;
      public void OnTriggerEnter(Collider other){
            if(other.gameObject.CompareTag("Player")){
                SceneManager.LoadScene("SampleScene");
            }
      }
}
