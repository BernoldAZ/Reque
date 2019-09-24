using UnityEngine;

public class ThrowObject : MonoBehaviour
{
  public Transform player;
  public Transform playerCam;
  public float throwForce = 10;
  bool beingCarried = false;
  public int dmg;
  private bool touched = false;
  private bool gett = false;

  void Start()
  {
  }

  void Update()
  {
    float dist = Vector3.Distance(gameObject.transform.position, player.position);
    Debug.Log(dist);
    if (dist <= 13f && gett)
    {
      GetComponent<Rigidbody>().isKinematic = true;
      transform.parent = playerCam;
      beingCarried = true;
    }
    if (beingCarried)
    {
      if (touched)
      {
        GetComponent<Rigidbody>().isKinematic = false;
        transform.parent = null;
        beingCarried = false;
        touched = false;
      }
      if (Input.GetMouseButtonDown(0))
      {
        GetComponent<Rigidbody>().isKinematic = false;
        transform.parent = null;
        beingCarried = false;
        GetComponent<Rigidbody>().AddForce(playerCam.forward * throwForce);
      }
      else if (Input.GetMouseButtonDown(1))
      {
        GetComponent<Rigidbody>().isKinematic = false;
        transform.parent = null;
        beingCarried = false;
      }
    }
  }

  void OnTriggerEnter()
  {
    if (beingCarried)
    {
      touched = true;
    }
  }
  public void UseObject()
  {
      gett = !gett;
    
  }


}

