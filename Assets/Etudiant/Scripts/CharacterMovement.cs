using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private GameObject head;
    [SerializeField] private float speed = 4.0f;

    private float _headTilt = 0;

    private CharacterController _characterController;

    private Vector3 _movementX;
    private Vector3 _movementZ;

    private void Awake() {
        _characterController = GetComponent<CharacterController>();
    }

    private void Update() {
        Vector3 movement = ( _movementX + _movementZ ).normalized;

        _characterController.Move( Physics.gravity * Time.deltaTime );
        _characterController.Move( movement * speed * Time.deltaTime );
    }

    public void TiltHead ( float mouseYValue ) {
        _headTilt -= mouseYValue;
        head.transform.localRotation = Quaternion.Euler( _headTilt, 0, 0 );
    }

    public void RotateY( float mouseXValue ) {
        transform.Rotate( 0, mouseXValue, 0 );
    }

    public void SetMovementX( float horizontalValue ) {
        _movementX = transform.right * horizontalValue;
    }

    public void SetMovementZ( float verticalValue ) {
        _movementZ = transform.forward * verticalValue;
    }
}
