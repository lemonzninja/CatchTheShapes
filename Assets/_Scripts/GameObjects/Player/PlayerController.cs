using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public float moveSpeed = 10.0f;
    [SerializeField] private float ScreenBoundaryPos;

    private Vector3 _playerPos;
    private Vector3 _position;
    private Transform _transform;

    private void Start()
    {
        _transform = transform;
        _position = transform.position;
    }


    public void MovePlayer()
    {
        // Get left/right input.
        var inputX = Input.GetAxis("Horizontal");

        // Move the player object
        _position += Vector3.right * (inputX * moveSpeed * Time.deltaTime);
        _transform.position = _position;

        // keep player object on screen.
        _playerPos = _position;
        var xPos = Mathf.Clamp(_playerPos.x, -ScreenBoundaryPos, ScreenBoundaryPos);
        _playerPos = new Vector3(xPos, _position.y, _position.z);
        _position = _playerPos;
    }
}