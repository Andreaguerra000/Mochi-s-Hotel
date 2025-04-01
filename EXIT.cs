using UnityEngine;
using UnityEngine.SceneManagement;
public class EXIT : MonoBehaviour
{
   public void ExitGame(){
    Debug.Log("We have quit the game");
    Application.Quit();
   }
}
