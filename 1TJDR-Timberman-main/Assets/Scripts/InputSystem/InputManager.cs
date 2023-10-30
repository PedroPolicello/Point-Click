using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;

public class InputManager
{
    public Action OnHit;

    private GameControls gameControls;

    public InputManager()
    {
        gameControls = new(); //Igual a new GameControls()
        gameControls.Enable();
        gameControls.Player.Hit.performed += Hit;
    }

    private void Hit(InputAction.CallbackContext context)
    {
        OnHit?.Invoke();
    }
}
