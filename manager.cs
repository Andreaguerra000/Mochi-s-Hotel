using UnityEngine;

public class manager : MonoBehaviour
{
    //manages spawn point for second -> first floor

    public GameObject mochi;
    public Transform spawnPoint;
    void Start()
    {
        Instantiate(mochi, spawnPoint.position, spawnPoint.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
