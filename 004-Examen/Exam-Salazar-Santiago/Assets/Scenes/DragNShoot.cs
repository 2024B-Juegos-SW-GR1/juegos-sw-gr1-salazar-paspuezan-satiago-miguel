using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragNShoot : MonoBehaviour
{
  public float power = 10f;
  public Rigidbody2D rb;
  public Vector2 minPower;
  public Vector2 maxPower;

  Camera cam;
  Vector2 force;
  Vector3 startPoint;
  Vector3 endPoint;
  TrayectoryLine tl;
  private void Start()
  {
    cam = Camera.main;
    tl = GetComponent<TrayectoryLine>();
  }

  private void Update()
  {
    if (Input.GetMouseButtonDown(0))
    {
      startPoint = cam.ScreenToWorldPoint(Input.mousePosition);
      startPoint.z = 15;
    }

    if (Input.GetMouseButton(0))
    {
      Vector3 currentPoint = cam.ScreenToWorldPoint(Input.mousePosition);
      currentPoint.z = 15;
      tl.RenderLine(startPoint, currentPoint);
    }
    if (Input.GetMouseButtonUp(0))
    {
      endPoint = cam.ScreenToWorldPoint(Input.mousePosition);
      endPoint.z = 15;
      
      force = new Vector2(Mathf.Clamp(startPoint.x-endPoint.x, minPower.x, maxPower.x),Mathf.Clamp(startPoint.y-endPoint.y, minPower.y, maxPower.y));
      
      rb.AddForce(force*power*1.5f, ForceMode2D.Impulse);
      tl.EndLine();
    }
  }
}
