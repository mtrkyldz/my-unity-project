using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameInput : MonoBehaviour
{
    public static GameInput Instance{get; private set;}
    public event EventHandler OnPauseAction;

    private PlayerInputActions playerInputActions;
    void Awake()
    {
        Instance = this;
        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();

        playerInputActions.Player.Pause.performed += Pause_performed;
    }

    private void OnDestroy(){
        playerInputActions.Player.Pause.performed -= Pause_performed;
        playerInputActions.Dispose();
    }

    private void Pause_performed(InputAction.CallbackContext context)
    {
        OnPauseAction?.Invoke(this, EventArgs.Empty);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Vector3 GetMovementVectorNormalized(){
        Vector2 direction = playerInputActions.Player.Move.ReadValue<Vector2>();
        return direction.normalized;
    }
}
