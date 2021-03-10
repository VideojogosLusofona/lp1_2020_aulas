using UnityEngine;

/// <summary>
/// This class represents the behavior of each cube.
/// </summary>
public class Rotator : MonoBehaviour
{
    // This is the rotation speed for the cubes
    [SerializeField]
    private float rotation = 25f;

    // Update is called once per frame
    private void Update()
    {
        // Rotate this cube!
        transform.Rotate(Vector3.one * rotation * Time.deltaTime);
    }
}
