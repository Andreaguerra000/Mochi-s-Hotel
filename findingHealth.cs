using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class findingHealth : MonoBehaviour
{
    public Image[] hearts;
    
        public float time = 1.0f;
        private bool isInv = false;
    private int life;
    void Start()
    {
        GameObject healthObj = GameObject.FindWithTag("healthsystem");
        if(healthObj != null){
            overallHealth healthS = healthObj.GetComponent<overallHealth>();
            updateHearts(healthS);
        }
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
            }
        }
         
        }

    void updateHearts() {
        int life = overallHealth.Instance.currentHearts;
          for(int i = 0; i < hearts.Length; i++){
                hearts[i].enabled = i < life;
          }
    }

    void updateHearts(overallHealth healthS) {
        int life = healthS.currentHearts;
          for(int i = 0; i < hearts.Length; i++){
                hearts[i].enabled = i < life;
          }
    }

    IEnumerator Chill(){
        isInv = true;
        yield return new WaitForSeconds(time);
        isInv = false;
    }
}
