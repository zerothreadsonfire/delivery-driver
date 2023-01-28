using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
  public GameObject player;

  private void Awake() {
    player = GameObject.Find("Driver");
  }

  private void LateUpdate() {
    transform.position = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
    // or transform.position = player.transform.position + new Vector3(0,0,-10)
  }
}
