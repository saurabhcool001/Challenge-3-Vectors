using UnityEngine;

public class VectorOperations
{
    // Add two vectors
    public static Vector3 Add(Vector3 v1, Vector3 v2)
    {
        return new Vector3(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
    }

    // Subtract two vectors
    public static Vector3 Subtract(Vector3 v1, Vector3 v2)
    {
        return new Vector3(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
    }

    // Dot product of two vectors
    public static float DotProduct(Vector3 v1, Vector3 v2)
    {
        return v1.x * v2.x + v1.y * v2.y + v1.z * v2.z;
    }

    // Cross product of two vectors
    public static Vector3 CrossProduct(Vector3 v1, Vector3 v2)
    {
        return new Vector3(
            v1.y * v2.z - v1.z * v2.y,
            v1.z * v2.x - v1.x * v2.z,
            v1.x * v2.y - v1.y * v2.x
        );
    }

    // Normalize a vector
    public static Vector3 Normalize(Vector3 v)
    {
        float magnitude = GetMagnitude(v);
        if (magnitude == 0) return Vector3.zero;
        return new Vector3(v.x / magnitude, v.y / magnitude, v.z / magnitude);
    }

    // Get the magnitude of a vector
    public static float GetMagnitude(Vector3 v)
    {
        return Mathf.Sqrt(v.x * v.x + v.y * v.y + v.z * v.z);
    }

    // Multiply a vector by a scalar
    public static Vector3 MultiplyByScalar(Vector3 v, float scalar)
    {
        return new Vector3(v.x * scalar, v.y * scalar, v.z * scalar);
    }
}