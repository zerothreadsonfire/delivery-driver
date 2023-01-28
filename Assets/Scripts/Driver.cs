using UnityEngine;

public class Driver : MonoBehaviour
{
  public float moveSpeed = 10f;
  public float steerSpeed = 100f;

  float steerDirection = 0f;
  float moveDirection = 0f;

  new Rigidbody2D rigidbody;

  private void Awake() {
    rigidbody = GetComponent<Rigidbody2D>();
  }

  private void Update() {
    steerDirection = Input.GetAxis("Horizontal");
    moveDirection = Input.GetAxis("Vertical");
  }

  private void FixedUpdate() {
    transform.Rotate(0, 0, -steerDirection * steerSpeed * Time.deltaTime);
    transform.Translate(0, moveDirection * moveSpeed * Time.deltaTime, 0);
  }
}
