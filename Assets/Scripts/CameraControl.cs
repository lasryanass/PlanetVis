using UnityEngine;
using UnityEngine.InputSystem;

public class CameraControl : MonoBehaviour
{
    public float rotationSpeed = 1.0f;
    public float zoomSpeed = 5.0f;

    public InputAction rotateXPositiveAction;
    public InputAction rotateXNegativeAction;
    public InputAction rotateYPositiveAction;
    public InputAction rotateYNegativeAction; 
    public InputAction rotateZPositiveAction;
    public InputAction rotateZNegativeAction;
    public InputAction zoomInAction;
    public InputAction zoomOutAction;

    private void OnEnable()
    {
        rotateXPositiveAction.Enable();
        rotateXNegativeAction.Enable(); 
        rotateYPositiveAction.Enable();
        rotateYNegativeAction.Enable();
        rotateZPositiveAction.Enable();
        rotateZNegativeAction.Enable();
        zoomInAction.Enable();
        zoomOutAction.Enable();
    }

    private void OnDisable()
    {
        rotateXPositiveAction.Disable();
        rotateXNegativeAction.Disable();
        rotateYPositiveAction.Disable();
        rotateYNegativeAction.Disable();
        rotateZPositiveAction.Disable();
        rotateZNegativeAction.Disable();
        zoomInAction.Disable();
        zoomOutAction.Disable();
    }


    void Update()
    {
        // Rotation autour de l'axe X (Up et Down)
        float rotationXPositive = rotateXPositiveAction.ReadValue<float>();
        float rotationXNegative = rotateXNegativeAction.ReadValue<float>();
        // Rotation autour de l'axe Y (F et G)
        float rotationYPositive = rotateYPositiveAction.ReadValue<float>();
        float rotationYNegative = rotateYNegativeAction.ReadValue<float>();
        // Rotation autour de l'axe Z (Left et Right)
        float rotationZPositive = rotateZPositiveAction.ReadValue<float>();
        float rotationZNegative = rotateZNegativeAction.ReadValue<float>();

        // Zoom avant (dézoomer) avec "Z"
        float zoomIn = zoomInAction.ReadValue<float>();
        // Dézoomer avec "X"
        float zoomOut = zoomOutAction.ReadValue<float>();

        transform.Rotate(Vector3.left, rotationXPositive * rotationSpeed);
        transform.Rotate(Vector3.right, rotationXNegative * rotationSpeed);

        transform.Rotate(Vector3.forward, rotationYPositive * rotationSpeed);
        transform.Rotate(Vector3.back, rotationYNegative * rotationSpeed);

        transform.Rotate(Vector3.up, rotationZPositive * rotationSpeed);
        transform.Rotate(Vector3.down, rotationZNegative * rotationSpeed);


        if (zoomIn > 0)
        {
            Camera.main.transform.Translate(Vector3.forward * zoomSpeed * Time.deltaTime);
        }

        if (zoomOut > 0)
        {
            Camera.main.transform.Translate(-Vector3.forward * zoomSpeed * Time.deltaTime);
        }
    }
}
