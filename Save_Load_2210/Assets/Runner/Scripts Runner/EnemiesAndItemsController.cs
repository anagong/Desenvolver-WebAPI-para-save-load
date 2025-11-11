using UnityEngine;

public class EnemiesAndItemsController : MonoBehaviour
{
    public float velocidade;
    void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime * velocidade);
    }
}
