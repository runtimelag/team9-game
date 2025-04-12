using UnityEngine;

public class MouseMovement : MonoBehaviour
{

    public float mouseSensitivity = 100f;

     float xRotation = 0f;
     float yRotation = 0f;

    public float topClamp = -90f;
    public float bottomClamp = 90f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // Getting mouse inputs
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Rotation arouns x axis
        xRotation -= mouseY;

        //clamp
        xRotation = Mathf.Clamp(xRotation, topClamp, bottomClamp);

        // y rotation
        yRotation += mouseX;

        transform.localRotation = Quaternion.Euler(xRotation,yRotation, 0f);
    }
}
