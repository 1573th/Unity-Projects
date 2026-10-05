using UnityEditor.Rendering;
using UnityEngine;

public class WhenTriggered : MonoBehaviour
{
    public GameObject winPanel;
    private void OnTriggerEnter(Collider other)
    {
        winPanel.SetActive(true);
        Time.timeScale = 0f;
    }
}
