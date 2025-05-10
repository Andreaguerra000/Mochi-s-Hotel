using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class winner : MonoBehaviour
{
    public Button mainM;

        void Start(){
            mainM.onClick.AddListener(mainmenu);
        }

        void mainmenu(){
            SceneManager.LoadScene("MainMenu");
        }
}
