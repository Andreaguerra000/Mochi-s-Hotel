using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
public class heartSystem : MonoBehaviour
{
        public Image[] hearts;
    
        public float time = 1.0f;
        private bool isInv = false;
    private int life;
    void Start()
    {
        updateHearts();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy") && !isInv)
        {
            Debug.Log("ive been hit");
            overallHealth.Instance.Damage(1);
            updateHearts();
            StartCoroutine(Chill());

            if(overallHealth.Instance.Dead()){
                Debug.Log("Player is dead");
                SceneManager.LoadScene("diedScene");
            }
        }
         
        }

    void updateHearts() {
        int currrentHealth = overallHealth.Instance.currentHearts;
          for(int i = 0; i < hearts.Length; i++){
                hearts[i].enabled = i < currrentHealth;
          }
    }

    IEnumerator Chill(){
        isInv = true;
        yield return new WaitForSeconds(time);
        isInv = false;
    }
}
