using UnityEngine.EventSystems;
using UnityEngine;

public class ScoringZone : MonoBehaviour
{
    // Event Trigger
    public EventTrigger.TriggerEvent scoreTrigger;

    // Can set collision triggers in the Editor!
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Get reference from the Ball class/script
        Ball ball = collision.gameObject.GetComponent<Ball>();

        // No garauntee that the object that collided is the ball, so check...
        if (ball != null) // if it wasn't the ball, don't run!
        {
            // Boiler plater Event Trigger stuff
            BaseEventData eventData = new BaseEventData(EventSystem.current);
            scoreTrigger.Invoke(eventData);
        }
    }
}
