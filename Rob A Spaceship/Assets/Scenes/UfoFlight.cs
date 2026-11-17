using UnityEngine;

public class UfoFlight : MonoBehaviour
{
    [SerializeField] private Camera menuCamera;
    [SerializeField, Min(1f)] private float secondsPerLap = 17f;

    private void Update()
    {
        // Viewport coordinates go from 0 to 1 across the camera view.
        float angle = (Time.timeSinceLevelLoad / secondsPerLap + 0.125f) * (2f * Mathf.PI);
        float x = 0.5f + Mathf.Cos(angle) * 0.37f;
        float y = 0.5f + Mathf.Sin(angle) * 0.33f;

        transform.position = menuCamera.ViewportToWorldPoint(new Vector3(x, y, 10f));
        transform.localScale = Vector3.one * Mathf.Min(1f, menuCamera.aspect);
    }
}
