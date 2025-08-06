using UnityEngine;

class Program : MonoBehaviour 
{
  void Start()
  {
    Cursor.lockState = CursorLockMode.Locked;
    Cursor.visible = false;
  }

  void Update()
  {
    float yInput = Input.GetAxis("Vertical");
    float xInput = Input.GetAxis("Horizontal");
    float sprintInput = Input.GetAxis("Fire 3");

    float speed = 5f;

    if (sprintInput != 0) 
    {
      speed = 5 + (sprintInput * 3);
    } else 
    {
      speed = 5f;
    }

    transform.Translate(Vector3.forward * speed * yInput);
    transform.Translate(Vector3.right * speed * xInput);
  }
}
