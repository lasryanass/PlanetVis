using UnityEngine;

public static class DrawTrajectory { 

    public static void DrawCircle(GameObject target, Vector2 center, float radius, Color color, float zPosition, int numSegments = 360)
    {
        LineRenderer lineRenderer = target.GetComponent<LineRenderer>();
        lineRenderer.startWidth = 0.1f;
        lineRenderer.endWidth = 0.1f;
        lineRenderer.positionCount = numSegments + 1;
        lineRenderer.startColor = color;
        lineRenderer.endColor = color;

        float angleIncrement = 360f / numSegments;

        for (int i = 0; i <= numSegments; i++)
        {
            float angle = i * angleIncrement * Mathf.Deg2Rad;
            float x = center.x + Mathf.Cos(angle) * radius;
            float y = center.y + Mathf.Sin(angle) * radius;
            lineRenderer.SetPosition(i, new Vector3(x, y, zPosition));
        }
    }
}