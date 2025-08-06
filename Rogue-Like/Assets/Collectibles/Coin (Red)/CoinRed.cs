using UnityEngine;

public class CoinRed : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Add coin (red)");
            Destroy(gameObject);
        }
    }
}
