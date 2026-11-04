using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector2 inputDirection;
    public Vector3 moveDirection;
    public Vector2 eulerVector;
    CharacterController characterController;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Move(inputDirection);
        Rotate(eulerVector);
        characterController.Move(moveDirection * Time.deltaTime);
    }

    public void Move(Vector2 direction) 
    {
        Vector3 forward = direction.y * transform.forward;
        Vector3 sideways = direction.x * transform.right;
        moveDirection = forward + sideways;

    }

    public void Rotate(Vector2 rotateAmount) 
    {
        float newAngle = transform.eulerAngles.y;
        newAngle += rotateAmount.y;
        Vector3 currentRotation = transform.eulerAngles;
        currentRotation.y = newAngle;
        transform.localRotation = Quaternion.Euler(0, newAngle, 0);
    }



}
