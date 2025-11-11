using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Item") || collision.gameObject.CompareTag("Fonte de dano"))
        {
            Destroy(collision.gameObject);
        }
    }
}
