using UnityEngine;

public class CoinRegular : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Add coin");
            Destroy(gameObject);
        }
    }
}
