using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    [SerializeField] float sensitivity;
    private float yRotation;
    private float zRotation;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        yRotation += mouseX;
        zRotation -= mouseY;

        zRotation = Mathf.Clamp(zRotation, -20, 20);

        transform.localRotation = Quaternion.Euler(0f, yRotation, zRotation);
    }
}
