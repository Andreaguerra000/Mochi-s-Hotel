using UnityEngine;

public class drawerKey : MonoBehaviour
{
    public GameObject drawer;
    public GameObject image;
    public GameObject doorOne; // this is technically the second room
    // this script is to ensure that once the drawer is selected, then we collect the key

    void Start()
    {
        image.SetActive(false);
        doorOne.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

          if(Input.GetMouseButtonDown(0)){
                if(Physics.Raycast(ray, out hit)){
                    if(hit.collider.gameObject == gameObject){
                        Debug.Log("Clicked the dresser");
                        image.SetActive(true);
                    }
                }
          }
    }
}
