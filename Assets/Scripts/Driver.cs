using UnityEngine;

public class Driver : MonoBehaviour
{
  public float moveSpeed = 20f;
  public float steerSpeed = 300f;
  public float boostSpeed = 25f;
  public float slowSpeed = 10f;

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

  private void OnCollisionEnter2D(Collision2D other) {
    moveSpeed = slowSpeed;
  }

  private void OnTriggerEnter2D(Collider2D other) {
    if(other.CompareTag("speedup")) {
      moveSpeed = boostSpeed;
    }
  }
}
