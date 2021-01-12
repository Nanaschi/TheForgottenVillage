using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // Distance between player and camera in horizontal direction
    public float xOffset = 0f;
    // Distance between player and camera in vertical direction
    public float yOffset = 0f;
    // Reference to the player's transform.
    public Transform player; //we can put the player gameobject to the unity slot because the player has a Transform component attached to it
    void LateUpdate() //it helps the camera follow the player only on the x axis
    {
        this.transform.position = new Vector3(player.transform.position.x +
        xOffset, this.transform.position.y + yOffset, -10);
    }
}
