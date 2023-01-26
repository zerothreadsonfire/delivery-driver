using UnityEngine;

public class Driver : MonoBehaviour
{
  public float moveSpeed;
  public float steerSpeed;

  private void Awake() {
    moveSpeed = 0.01f;
    steerSpeed = 1f;
  }

  private void Update() {
    transform.Rotate(0, 0, steerSpeed);
    transform.Translate(0, moveSpeed, 0);
  }

  private void FixedUpdate() {
    
  }
}
