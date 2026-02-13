using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
   public float sensitivity = 200f; 
   public Transform player;
   float xRotation = 0f;
   float yRotation = 0f;
  
   
    void Start()
    {
        //Locks cursor and hides it during play (easier for testing too)
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

   
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        xRotation -= mouseY; //X-axis left and right
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); //Limit rotation over 90 degrees 
        yRotation += mouseX; //Y-axis up and down

        player.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
    }
}
