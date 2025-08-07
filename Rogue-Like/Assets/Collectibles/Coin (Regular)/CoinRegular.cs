using UnityEngine;

public class CoinRegular : MonoBehaviour
{
    public CollectiblesEventChannel collectiblesEventChannel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Add coin");

            collectiblesEventChannel.RaiseEvent();

            Destroy(gameObject);
        }
    }
}
