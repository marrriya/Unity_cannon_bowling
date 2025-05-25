using UnityEngine;

public class BallCamera : MonoBehaviour {
    public Transform target;
    public Vector3 offset = new Vector3(0, 2, -5);
    
    void LateUpdate() {
        if (target != null) {
            transform.position = target.position + offset;
            transform.LookAt(target);
        }
    }
}