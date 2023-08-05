using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameInput : MonoBehaviour
{
    private PlayerInputAction action;
    private void Awake()
    {
        action = new PlayerInputAction();
        action.Player.Enable();
    }
    public Vector2 GetMovementVectorNormalized() {

        Vector2 inputVector = action.Player.Move.ReadValue<Vector2>();
        inputVector = inputVector.normalized;
        return inputVector;
    }
}
