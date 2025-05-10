using UnityEngine;
using UnityEngine.SceneManagement;
public class NEWGAME : MonoBehaviour
{

    //if the user presses start game, the user will be taken to the beginning of the game
    public void StartGame(){
        Debug.Log("Starting Game");
        SceneManager.LoadScene("SampleScene");
    }
}
