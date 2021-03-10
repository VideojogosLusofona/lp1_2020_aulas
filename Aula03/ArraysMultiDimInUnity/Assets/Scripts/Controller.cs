using UnityEngine;

/// <summary>
/// This class controls the behavior of the grid of cubes.
/// </summary>
public class Controller : MonoBehaviour
{
    // This is the cube prefab (or prototype), from which all other cubes will
    // be copied
    [SerializeField]
    private GameObject elementPrefab;

    // Number of rows in the grid of cubes (change this value in the Controller
    // game object in the Unity editor, not here)
    [SerializeField]
    private int rows = 25;

    // Number of columns in the grid of cubes  (change this value in the
    // Controller game object in the Unity editor, not here)
    [SerializeField]
    private int cols = 25;

    // Camera distance from center of the grid (change this value in the
    // Controller game object in the Unity editor, not here)
    [SerializeField]
    private float cameraDistance = 1.5f;

    // Camera rotation speed (change this value in the
    // Controller game object in the Unity editor, not here)
    [SerializeField]
    private float cameraRotationSpeed = 0.5f;

    // Bi-dimension array of booleans which indicates what cubes will be spawned
    // in the grid of cubes
    private bool[,] lightSwitches;

    // Awake is called when the script instance is being loaded
    private void Awake()
    {
        // Create bi-dimensional array of booleans
        lightSwitches = new bool[rows, cols];

        // Fill the grid of booleans
        for (int i = 0; i < lightSwitches.GetLength(0); i++)
        {
            for (int j = 0; j < lightSwitches.GetLength(1); j++)
            {
                // This will enable cubes randomly in the grid
                if (Random.Range(0, 2) == 1) lightSwitches[i, j] = true;

                // This will create a pattern of cubes, try to understand why
                // Uncomment it to try it out (and comment the other line above)
                // if (i % 2 == 0 || j % 4 == 0) lightSwitches[i, j] = true;
            }
        }

        // Goals for LP1 students:
        // 1. Comment both for loops and create a drawing of cubes by manually
        //    specifying which cubes are spawned by setting the respective
        //    bi-dimensional array index to true
        // 2. For more advanced students: change the code in this class so that
        //    you have a 3D-grid of cubes (i.e. a cube of cubes) instead of a
        //    2D grid like we have now
    }

    // Start is called before the first frame update
    private void Start()
    {
        // Determine a lower corner of the grid
        float y = -rows / 2f;
        float x = -cols / 2f;

        // Go through the bi-dimensional array of booleans and spawn cubes when
        // the value is true
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                // Is the value true in this position of the array?
                if (lightSwitches[i, j])
                {
                    // If so, spawn a cube
                    Instantiate(
                        elementPrefab,
                        new Vector3(x + j, y + i, 0), Quaternion.identity);
                }
            }
        }
    }

    // Update is called once per frame
    // We use to orbit the camera around the cube grid
    private void Update()
    {
        // Determine the radius which the camera will orbit around the
        // center of the grid
        float radius = cameraDistance
            * Mathf.Max(lightSwitches.GetLength(0), lightSwitches.GetLength(1));

        // Determine camera position in its orbit around the center of the grid
        Camera.main.transform.position = radius
            * new Vector3(
                Mathf.Sin(cameraRotationSpeed * Time.time),
                0,
                Mathf.Cos(cameraRotationSpeed * Time.time));

        // Make camera look at center of the grid
        Camera.main.transform.LookAt(Vector3.zero);
    }
}
