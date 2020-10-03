using UnityEngine;
using System.Collections;

public class FirstPersCAM : MonoBehaviour {

public float turnSpeed = 4.0f;
public float moveSpeed = 2.0f;
 
public float minTurnAngle = -90.0f;
public float maxTurnAngle = 90.0f;
private float rotX;
 
void Update ()
{
    MouseAiming();
    KeyboardMovement();
}
 
void MouseAiming ()
{
    // get the mouse inputs
    float y = Input.GetAxis("Mouse X") * turnSpeed;
    rotX += Input.GetAxis("Mouse Y") * turnSpeed;
 
    // clamp the vertical rotation
    rotX = Mathf.Clamp(rotX, minTurnAngle, maxTurnAngle);
 
    // rotate the camera
    transform.eulerAngles = new Vector3(-rotX, transform.eulerAngles.y + y, 0);
}
 
void KeyboardMovement ()
{
    Vector3 dir = new Vector3(0, 0, 0);
 
    dir.x = Input.GetAxis("Horizontal");
    dir.z = Input.GetAxis("Vertical");
 
    transform.Translate(dir * moveSpeed * Time.deltaTime);
}
}