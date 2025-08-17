 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewBehaviourScript : MonoBehaviour
{

    private Vector2 movement;
    private Rigidbody2D rb;

    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }
        


            private void OnMovement(InputValue value) => movement = value.Get<Vector2>();

            private void FixedUpadte() => rb.MovePosition(rb.position + movement * Time.fixedDeltaTime);
        }


