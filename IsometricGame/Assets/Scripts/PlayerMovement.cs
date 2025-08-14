 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewBehaviourScript : MonoBehaviour{

    private Vector2 movement;
    private void OnMovement(InputValue value) {
        movement = value.Get<Vector2>();
    }
