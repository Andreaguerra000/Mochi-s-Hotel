using UnityEngine;
using UnityEngine.UI;
public class slider : MonoBehaviour
{
    public Slider sl;
    public GameObject lightsParent;
    public GameObject[] lights;
    void Start(){
        lights = new GameObject[lightsParent.transform.childCount];
        for(int i = 0; i < lightsParent.transform.childCount; i++){
            lights[i] = lightsParent.transform.GetChild(i).gameObject;
            lights[i].SetActive(false);
        }
    }
    void Update()
    {
        if(sl.value >= sl.maxValue){
            foreach(GameObject light in lights){
                if(!light.activeSelf){
                    light.SetActive(true);
                }
            }
        }
    }
}
