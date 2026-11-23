using System.Runtime.InteropServices;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [Header("Referências")]
    [SerializeField] private Transform playerView;

    [SerializeField] private Transform playerCamera;

    [Header("Sensibilidade")]
    [SerializeField] private float mouseSensibilityX = 120f;
    [SerializeField] private float mouseSensibilityY = 100f;

    [Header("Limites horizontais da camera")]
    [SerializeField] private float maxlookLeft = 80f;
    [SerializeField] private float maxLookRight = 80f;

    [Header("Limites verticais da camera")]
    [SerializeField] private float minLookVertical = -45f;
    [SerializeField] private float maxLookVertical = 45f;

    private float yaw;

    private float pitch;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        readMouse();
        RotateCamera();
    }

    private void readMouse()
    {

        float mouseX = Input.GetAxis("Mouse X") * mouseSensibilityX * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensibilityY * Time.deltaTime;

        yaw += mouseX;

        pitch -= mouseY;

        yaw = Mathf.Clamp(yaw, -maxlookLeft, maxLookRight);

        pitch = Mathf.Clamp(pitch, minLookVertical, maxLookVertical);

        
    }

    private void RotateCamera()
    {
        playerCamera.localRotation = Quaternion.Euler(0f, yaw, 0f);

        playerView.localRotation = Quaternion.Euler(pitch, 0f, 0f);
    }
}
