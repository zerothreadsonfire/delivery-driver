using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionMechanics : MonoBehaviour
{
  public float destroyDelay = 0.5f;
  public Color32 hasPackageColor = new Color32(1,1,1,1);
  public Color32 noPackageColor = new Color32(1,1,1,1);

  bool hasPackage = false;
  SpriteRenderer spriteRenderer;
  private void Awake() {
    spriteRenderer = GetComponent<SpriteRenderer>();
  }
  private void OnCollisionEnter2D(Collision2D other) {
    Debug.Log("collision");
  }

  private void OnTriggerEnter2D(Collider2D other) {
    if(hasPackage == false && other.CompareTag("package")) {
      hasPackage = true;
      spriteRenderer.color = hasPackageColor;
      Destroy(other.gameObject, destroyDelay);
    } 
    
    if(hasPackage == true && other.CompareTag("customer")) {
      hasPackage = false;
      spriteRenderer.color = noPackageColor;
    }
  }
}
