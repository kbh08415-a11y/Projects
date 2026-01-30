using UnityEngine;
using UnityEngine.Rendering;

public class Trigger : MonoBehaviour
{
    public bool triggered = false;

    public void OnTriggerEnter(Collider other)
    { 
        MeshRenderer meshrend = GetComponent<MeshRenderer>();
        meshrend.material.color = Color.green;

        triggered = true;

    }
    //// Start is called once before the first execution of Update after the MonoBehaviour is created
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
        
    //}
}
