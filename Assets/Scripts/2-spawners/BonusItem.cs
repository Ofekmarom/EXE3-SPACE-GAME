using UnityEngine;

public class BonusItem : MonoBehaviour
{
    [SerializeField] private int pointsToAdd = 1; // ��� ������ �������� �����

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        { // ����� ������� �� ������
            GAME_STATUS.playerScore += pointsToAdd; // ����� ������

            // update the score display

            NumberField scoreField = Object.FindFirstObjectByType<NumberField>(); 
            if (scoreField != null)
            {
                scoreField.AddNumber(pointsToAdd);
            }

            Destroy(gameObject); // ����� ��������
        }
    }
}
