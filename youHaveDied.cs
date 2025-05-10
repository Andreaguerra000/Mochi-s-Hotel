using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class youHaveDied : MonoBehaviour
    {
        public Button tryAgain;
        public Button exit;

        void Start(){
            tryAgain.onClick.AddListener(trying);
            exit.onClick.AddListener(exitting);
        }

        void trying(){
            SceneManager.LoadScene("SampleScene");
        }
        void exitting(){
            SceneManager.LoadScene("MainMenu");

        }
}
