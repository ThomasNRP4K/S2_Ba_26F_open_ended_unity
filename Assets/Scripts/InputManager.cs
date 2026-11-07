using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public static class InputManager 
{
    static PlayerController playerController;

    public static Player player;


    public static void Initialize(Player _player)
    {
        player = _player;
        playerController = new PlayerController();
        playerController.Gameplay.Enable();
        playerController.Gameplay.Move.performed += HandleMovement;
        playerController.Gameplay.Move.canceled += HandleMovement;
        //2026-11-12 planned code to be added on student side
        playerController.Gameplay.Look.performed += HandleLook;
        playerController.Gameplay.Jump.performed += HandleJump;
        //----------------------------------
    }

    private static void HandleMovement(InputAction.CallbackContext context)
    {
        player.Move(context.ReadValue<Vector2>());
    }


    //2026-11-12 planned code to be added on student side
    private static void HandleLook(InputAction.CallbackContext context)
    {
        player.Rotate(context.ReadValue<Vector2>().normalized * 2);
    }

    private static void HandleJump(InputAction.CallbackContext context)
    {
        player.Jump();
    }



    //---------------------------



}
