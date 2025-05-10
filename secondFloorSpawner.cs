using UnityEngine;
using UnityEngine.SceneManagement;
public class secondFloorSpawner : MonoBehaviour
{
    public Transform spawnPoint;
    void Start()
    {
        GameObject player = GameObject.FindWithTag("Player");
        if(player != null && spawnPoint != null){
            player.transform.position = spawnPoint.position;
            player.transform.rotation = spawnPoint.rotation;

             Rigidbody rb = player.GetComponent<Rigidbody>();
            if (rb != null) {
            rb.velocity = Vector3.zero;            // Reset linear velocity
            rb.angularVelocity = Vector3.zero;    // Reset angular velocity
        }
        
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
