using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    public GameObject pathToAppear;
    void OnTriggerEnter(Collider other)
    {
        pathToAppear.SetActive(true);
        Destroy(gameObject);
    }

}
