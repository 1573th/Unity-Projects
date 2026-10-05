using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    public GameObject pathToAppear;

    public GameObject pathToDisappear;
    void OnTriggerEnter(Collider other)
    {
        try
        {
            if (pathToAppear) pathToAppear.SetActive(true);
            if (pathToDisappear) pathToDisappear.SetActive(false);
            Destroy(gameObject);
        }  catch { }
    }

}
