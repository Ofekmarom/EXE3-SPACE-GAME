using UnityEngine;

public class BonusItem : MonoBehaviour
{
    [SerializeField] private int pointsToAdd = 1; // כמה נקודות האובייקט מוסיף

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        { // זיהוי התנגשות עם החללית
            GAME_STATUS.playerScore += pointsToAdd; // עדכון הניקוד

            // update the score display

            NumberField scoreField = Object.FindFirstObjectByType<NumberField>(); 
            if (scoreField != null)
            {
                scoreField.AddNumber(pointsToAdd);
            }

            Destroy(gameObject); // השמדת האובייקט
        }
    }
}
