using UnityEngine;

public class HourglassRegular : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Add time - timer was collected");
            Destroy(gameObject);
        }
    }
}
