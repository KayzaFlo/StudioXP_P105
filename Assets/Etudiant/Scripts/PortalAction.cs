using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalAction : MonoBehaviour
{
    private bool _isPortalComplete = false;

    private void OnTriggerEnter(Collider other) {
        if ( other.CompareTag("Player") && _isPortalComplete ) {
            SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex + 1 );
            Debug.Log( "Portal Triggered" );
        }
    }

    public void SetIsPortalComplete( bool trueOrFalse ) {
        _isPortalComplete = trueOrFalse;
    }
}
