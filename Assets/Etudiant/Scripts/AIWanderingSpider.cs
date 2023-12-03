using System.Collections;
using UnityEngine;

public class AIWanderingSpider : MonoBehaviour
{
    [SerializeField] private bool waiting = false;

    [SerializeField] private float range = 5.0f;
    [SerializeField] private float minWaitTime = 0.0f;
    [SerializeField] private float maxWaitTime = 2.0f;

    private AIMovementFunction _aiMovement;

    private void Awake() {
        _aiMovement = GetComponent <AIMovementFunction>();
    }

    private void Update() {
        if ( !waiting ) {
            waiting = true;
            _aiMovement.MoveToRandom( transform.position, range );
            StartCoroutine( StopWait() );
        }
    }

    private IEnumerator StopWait() {
        yield return new WaitForSeconds( Random.Range( minWaitTime, maxWaitTime ) );
        waiting = false;
    }
}
