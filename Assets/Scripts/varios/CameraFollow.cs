using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

public Vector2 minCampos,maxCampos;
public GameObject follow;
Vector2 velocity;
public float smoothTime;


void FixedUpdate(){
              Follow();

}

void Follow(){
                                     float posX = Mathf.SmoothDamp(transform.position.x, 
                                     follow.transform.position.x, ref velocity.x, smoothTime);
                                     float posY = Mathf.SmoothDamp(transform.position.y, 
                                     follow.transform.position.y, ref velocity.y, smoothTime);
                                     transform.position = new Vector3(
                                     Mathf.Clamp(posX, minCampos.x , maxCampos.x),
                                     Mathf.Clamp(posY, minCampos.y , maxCampos.y),
                                     transform.position.z);
                                     
}
}
