using UnityEngine;
using UnityEngine.UI;
public class secondFloorMap : MonoBehaviour
{
    public Button mapButton;
    public Button ExitMap;
    public GameObject key;
    public GameObject doorExist;
    public GameObject otherDoor;
    public GameObject firstPortion;
    public GameObject secondPortion;
    public GameObject thirdPortion;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mapButton.onClick.AddListener(Allmaps);
        ExitMap.onClick.AddListener(ExitingMap);
        
        firstPortion.SetActive(false);
        secondPortion.SetActive(false);
        thirdPortion.SetActive(false);

        mapButton.gameObject.SetActive(true);
        ExitMap.gameObject.SetActive(false);
    }

    void Allmaps(){

            ExitMap.gameObject.SetActive(true);
            if(doorExist.activeSelf && otherDoor.activeSelf){
                firstPortion.SetActive(true);
                secondPortion.SetActive(false);
                thirdPortion.SetActive(false);
            }

            else if(!doorExist.activeSelf && otherDoor.activeSelf){
                firstPortion.SetActive(false);
                secondPortion.SetActive(true);
                thirdPortion.SetActive(false);
            }
            else if(!doorExist.activeSelf && !otherDoor.activeSelf){
                firstPortion.SetActive(false);
                secondPortion.SetActive(false);
                thirdPortion.SetActive(true);
            }
    }
    void ExitingMap(){
        ExitMap.gameObject.SetActive(false);
        firstPortion.SetActive(false);
        secondPortion.SetActive(false);
        thirdPortion.SetActive(false);
    }
   
    
}
