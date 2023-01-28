using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionMechanics : MonoBehaviour
{
  private void OnCollisionEnter2D(Collision2D collision) {
    Debug.Log("collision");
  }

  private void OnTriggerEnter2D(Collider2D collision) {

    // if trigger is package then pick it up
    Debug.Log("trigger");
  }
}
