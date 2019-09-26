using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup_objects : MonoBehaviour
{
  // Start is called before the first frame update
  public GameObject controller;
  public Transform objecto;
  public float distance;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    RaycastHit hit;
    Ray rayo = Camera.main.ScreenPointToRay(Input.mousePosition);
    Debug.DrawRay(transform.position, transform.forward, Color.green);

        
    }
}
