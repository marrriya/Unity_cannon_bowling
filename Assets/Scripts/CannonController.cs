using UnityEngine;

public class CannonController : MonoBehaviour
{
    public GameObject cannonBallPrefab;
    public Transform barrelEnd;
    public float shootForce = 10f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject ball = Instantiate(cannonBallPrefab, barrelEnd.position, barrelEnd.rotation);
            ball.GetComponent<Rigidbody>().AddForce(barrelEnd.forward * shootForce, ForceMode.Impulse);
        }
    }
}