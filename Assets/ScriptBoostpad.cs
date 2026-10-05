using UnityEngine;

public class ScriptBoostpad : MonoBehaviour
{
    public float boostForce = 60f;

    private void OnTriggerStay(Collider other)
    {
        other.attachedRigidbody.AddForce(transform.forward * boostForce);
    }

}
