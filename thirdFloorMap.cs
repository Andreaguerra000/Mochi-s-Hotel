using UnityEngine;
using UnityEngine.UI;
public class thirdFloorMap : MonoBehaviour
{
    public GameObject one;
    public GameObject two;
    public GameObject finalBoss;
    public Button mapButton;
    public Button ExitMap;
    void Start()
    {
        one.SetActive(false);
        two.SetActive(false);
        mapButton.onClick.AddListener(mapClicked);
        ExitMap.onClick.AddListener(ExitingMap);
        ExitMap.gameObject.SetActive(false);
    }

    void mapClicked(){ 
        
        if(finalBoss == null){
         one.SetActive(true);
         two.SetActive(false); 
        }
        else{
            one.SetActive(false);
            two.SetActive(true);
        }
        
        ExitMap.gameObject.SetActive(true);
    }
    void ExitingMap(){
        one.SetActive(false);
        two.SetActive(false);
        ExitMap.gameObject.SetActive(false);
    }

    
}
