using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using System;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody myRBD;
    [SerializeField] private float velocity;
    [SerializeField] private float jumpForce = 4f;
    [SerializeField] private float checkDistance = 5f;
    [SerializeField] private LayerMask groundLayers;
    [SerializeField] private AudioSource audiosource;
    private Vector2 _movement;
    private bool canJump;

    private void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    private void FixedUpdate()
    {
        myRBD.velocity = new Vector3(_movement.x, myRBD.velocity.y, _movement.y);
        canJump = Physics.Raycast(transform.position, Vector3.down, checkDistance, groundLayers);
        Debug.DrawRay(transform.position, Vector3.down * checkDistance, Color.red);
        AudioMovement();
    }

    public void AudioMovement()
    {
        if (_movement.magnitude > 0)
        {
            if (!audiosource.isPlaying)
            {
                audiosource.Play();
            }
        }
        else
        {
            audiosource.Stop();
        }

    }
    public void OnMovement(InputAction.CallbackContext context)
    {
        _movement = context.ReadValue<Vector2>() * velocity;
    }
    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if (canJump)
            {
                myRBD.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }

        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "portal")
        {
            SceneManager.LoadScene("Nivel2");
        }
        if (collision.gameObject.tag == "portal1")
        {
            SceneManager.LoadScene("Nivel1");
        }
    }
}
