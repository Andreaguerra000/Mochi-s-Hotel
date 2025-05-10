using UnityEngine;
using UnityEngine.UI;
public class firstFloorMap : MonoBehaviour
{
   
    public GameObject firstFloor1;
    public GameObject firstFloor2;
    public GameObject keyExist;
    public Button mapButton;
    public Button ExitMap;
//displays map when clicked for outside area
    void Start(){
        mapButton.onClick.AddListener(mapClicked);
        ExitMap.onClick.AddListener(ExitingMap);
        firstFloor1.SetActive(false);
        firstFloor2.SetActive(false);
        ExitMap.gameObject.SetActive(false);
        }
    void mapClicked(){
        Debug.Log("button clicked");
        if(keyExist != null){
            firstFloor1.SetActive(true);
            firstFloor2.SetActive(false);
        }
        else{
             firstFloor1.SetActive(false);
            firstFloor2.SetActive(true);
        }
       
        ExitMap.gameObject.SetActive(true);
    }
    void ExitingMap(){
        firstFloor1.SetActive(false);
        firstFloor2.SetActive(false);
        firstFloor1.gameObject.SetActive(false);
        ExitMap.gameObject.SetActive(false);
    }
}
