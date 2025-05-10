using UnityEngine;

public class elevator1 : MonoBehaviour
{
    public GameObject floorOneElevator;
    public GameObject leverUp;
    public GameObject leverdown;
     public bool truth = false;
  
    void Start()
    {
       floorOneElevator = GameObject.FindWithTag("elevator1");
       leverUp = GameObject.FindWithTag("rodup");
       leverdown = GameObject.FindWithTag("roddown");
   
        
    }

    // will disbale the collider of the elevator one the elever is pulled down
    void Update() {
            if(leverUp.activeSelf){
                floorOneElevator.GetComponent<Collider>().enabled = true;
            }
            else if(!leverUp.activeSelf){
                 floorOneElevator.GetComponent<Collider>().enabled = false;

            }
    }
}
