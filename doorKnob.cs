using UnityEngine;

public class doorKnob : MonoBehaviour
{
    public GameObject doork;
    public GameObject usedKey;
    public GameObject doorToOpen;
    public GameObject image;
    public bool haskey = false;

    // Update is called once per frame
    void Update()
    {
        if(image.activeSelf){
            haskey = true;
        }
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
         if(Input.GetMouseButtonDown(0)){
                if(Physics.Raycast(ray, out hit)){
                    if(hit.collider.gameObject == gameObject){
                        if(haskey){
                        Debug.Log("door knob clicked");
                        doorToOpen.SetActive(false);
                        usedKey.SetActive(false);
                        doork.SetActive(false);
                        }
                        else{
                            Debug.Log("you need a key");
                        }
                    }
                }
          }
        
    }
}
