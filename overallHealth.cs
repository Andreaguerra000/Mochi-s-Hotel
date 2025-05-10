using UnityEngine;
using UnityEngine.SceneManagement;
public class overallHealth : MonoBehaviour
{
    public static overallHealth Instance;
    public int maxHearts = 5;
    public int currentHearts;
    
    void Awake(){
        if(Instance == null){
            Instance = this;
            DontDestroyOnLoad(gameObject);
            currentHearts = maxHearts;
            Debug.Log("overall health instance created and persisted");
        }
        else{
            Destroy(gameObject);
            Debug.Log("overall health instance ");
        }
    }

    public void Damage(int amount){
        currentHearts -= amount;
        if(currentHearts <= 0){
            currentHearts = 0;
            Die();
        }
    }

    public bool Dead(){
        return currentHearts <= 0;
    }
    private void Die(){
        Debug.Log("you have died");
    }
}
