using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    CharacterController characterController;

    public Vector3 moveDirection;

    //2026-11-12 planned code to be added on student side for rotation 
    // and jumping 
    public float gravityScale = -9.81f;
    public float jumpHeight = 2.0f;
    //------------------------

    void Awake()
    {
        InputManager.Initialize(this);
    }
    
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        characterController.Move(moveDirection * Time.deltaTime);


        //2026-11-12 planned code to be added on student side
        Fall();
        //-------------------
       
    }

    public void Move(Vector2 direction) 
    {
        Vector3 forward = direction.y * transform.forward;
        Vector3 sideways = direction.x * transform.right;
        moveDirection = forward + sideways;

    }

    //2026-11-12 planned code to be added on student side
    public void Rotate(Vector2 rotateAmount) 
    {
        float newAngle = transform.eulerAngles.y;
        newAngle += rotateAmount.x;
        transform.localRotation = Quaternion.Euler(0, newAngle, 0);
    }
    //-------------------



    //2026-11-12 planned code to be added on student side for rotation 
    // and jumping 
    public void Jump()
    {
        if (characterController.isGrounded)
        {
            moveDirection.y = Mathf.Sqrt(jumpHeight * -2.0f * gravityScale);
        }
    }

    public void Fall()
    {
        moveDirection.y += -9.81f * Time.deltaTime;
    }

    //-------------------------



}
