using UnityEditorInternal;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    public int score = 1;
    private Score_Manager score_Manager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score_Manager = FindFirstObjectByType<Score_Manager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        score_Manager.AddScore(score);
        Destroy(gameObject);
    }

}
