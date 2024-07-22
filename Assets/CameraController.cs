// using UnityEngine;

// public class CameraController : MonoBehaviour
// {
//     public float moveSpeed = 10.0f;

//     void Update()
//     {
//         // Get input from the user
//         float horizontalInput = Input.GetAxis("Horizontal"); // A/D or Left/Right arrows
//         float verticalInput = Input.GetAxis("Vertical"); // W/S or Up/Down arrows

//         // Calculate movement vector
//         Vector3 movement = new Vector3(horizontalInput, 0, verticalInput) * moveSpeed * Time.deltaTime;

//         // Move the camera
//         transform.Translate(movement, Space.World);
//     }
// }
