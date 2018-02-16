using UnityEngine;

public class PlayerCasting : MonoBehaviour
{
    private static float _distanceFromTarget;

    public static float DistanceFromTarget;

    private void Update()
    {
        RaycastHit raycastHit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out raycastHit))
        {

            _distanceFromTarget = raycastHit.distance;
            DistanceFromTarget = _distanceFromTarget;
        }
    }
}