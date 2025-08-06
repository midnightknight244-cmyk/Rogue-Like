using UnityEngine;

public class CoinBlue : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Add coin (blue)");
            Destroy(gameObject);
        }
    }
}
