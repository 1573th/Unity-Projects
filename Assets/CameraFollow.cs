using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    [Range(5f, 89f)]

    public float angle = 45f;   // how steeply it looks down
    public float height = 8f;   // how high above the cube it sits

    void LateUpdate()
    {
        if (target == null) return;

        // how far back it needs to be to look down at that angle
        float distance = height / Mathf.Tan(angle * Mathf.Deg2Rad);

        transform.position = target.position + new Vector3(0f, height, -distance);
        transform.rotation = Quaternion.Euler(angle, 0f, 0f);
    }
}