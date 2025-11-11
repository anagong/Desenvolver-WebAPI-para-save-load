using System.Threading;
using UnityEngine;

public class RandomPrefabSpawner : MonoBehaviour
{
    public float temporizador;
    public GameObject[] prefabs;
    public Vector3[] spawners;

    void Start()
    {
        TemporizadorAleatorio();
    }

    void Update()
    {
        temporizador -= Time.deltaTime; //Conta pra baixo
        if(temporizador < 0)
        {
            Instantiate(prefabs[Random.Range(0, spawners.Length)], spawners[Random.Range(0, spawners.Length)], Quaternion.identity);
            TemporizadorAleatorio();
        }
    }

    void TemporizadorAleatorio()
    {
        temporizador = Random.Range(0.4f, 1.4f);
    }
}
