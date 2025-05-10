using UnityEngine;
using UnityEngine.SceneManagement;
public class BackToMAIN : MonoBehaviour
{
   public GameObject backToMain;
      public void OnTriggerEnter(Collider other){
            if(other.gameObject.CompareTag("Player")){
                SceneManager.LoadScene("SampleScene");
            }
      }
}
