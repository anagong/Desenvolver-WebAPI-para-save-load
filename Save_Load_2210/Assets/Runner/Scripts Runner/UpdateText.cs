using UnityEngine;

public class UpdateText : MonoBehaviour
{
    private float timer;
    private void OnEnable()
    {
        timer = 1.2f;
    }
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer < 0)
        {
            gameObject.SetActive(false);
        }
    }
}
