using UnityEngine;
using UnityEngine.SceneManagement;
public class NEWGAME : MonoBehaviour
{
    public void StartGame(){
        Debug.Log("Starting Game");
        SceneManager.LoadScene("SampleScene");
    }
}
