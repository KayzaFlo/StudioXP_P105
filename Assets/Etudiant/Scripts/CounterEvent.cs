using UnityEngine;
using UnityEngine.Events;

public class CounterEvent : MonoBehaviour
{
    [SerializeField] private int minValue = 0;
    [SerializeField] private int maxValue = 10;
    [SerializeField] private int startValue = 0;
    [SerializeField] private UnityEvent onMaxReached;

    private int counter;

    private void Start() {
        counter = startValue;
    }

    [ContextMenu( "Increment" )]
    public void IncrementCounter() {
        if ( counter < maxValue )
            counter++;
            
        if ( counter > maxValue )
            counter = maxValue;

        if ( counter == maxValue ) {
            onMaxReached.Invoke();
        }
    }
}
