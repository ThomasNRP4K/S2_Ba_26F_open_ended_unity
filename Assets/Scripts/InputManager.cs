using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    PlayerController playerController;

    public Player player;


    void Start()
    {
        playerController = new PlayerController();
        playerController.Gameplay.Enable();
        playerController.Gameplay.Move.performed += HandleMovement;
        playerController.Gameplay.Look.performed += HandleLook;
    }

    private void HandleMovement(InputAction.CallbackContext ctx)
    {
        player.Move(ctx.ReadValue<Vector2>());
    }

    private void HandleLook(InputAction.CallbackContext ctx)
    {
        player.Rotate(ctx.ReadValue<Vector2>().normalized * 2);
    }



}
