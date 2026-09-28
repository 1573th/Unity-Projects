using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    public GameObject pathToAppear;
    void OnTriggerEnter(Collider other)
    {
        try
        {
            pathToAppear.SetActive(true);
            
        }  catch { }
        Destroy(gameObject);
    }

}
