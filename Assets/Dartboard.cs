using UnityEngine;
using TMPro;

public class TargetScorer : MonoBehaviour
{
    public Transform center;
    public TextMeshProUGUI scoreLabel;

    private int totalScore = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Throwable"))
        {
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.isKinematic = true;            }

            float distance = Vector3.Distance(collision.transform.position, center.position);

            int points = getPoints(distance);
            totalScore += points;

            scoreLabel.text = "Score: " + totalScore;
        }
    }

    private int getPoints(float distance)
    {
        if (distance <= 0.3f) return 100;
        if (distance <= 0.6f) return 50;
        if (distance <= 1.2f) return 20;
        return 5;
    }
}