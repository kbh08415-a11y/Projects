using System;
using UnityEngine;

public class Collecting : MonoBehaviour
{

    public static event Action OnCollected;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OnCollected?.Invoke();
            Destroy(gameObject);
        }
    }



    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}
}
