using UnityEngine;

public class Cannon : MonoBehaviour 
{
    public GameObject cannonBallPrefab;
    public Transform barrelEnd;
    public float firePower = 15f;
    public ParticleSystem muzzleFlash; // Добавляем эффект дульного вспышки

    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Fire();
        }
    }

    void Fire() 
    {
        // Эффект выстрела
        if (muzzleFlash != null)
            muzzleFlash.Play();

        // Создание шара
        GameObject ball = Instantiate(cannonBallPrefab, barrelEnd.position, barrelEnd.rotation);
        ball.GetComponent<Rigidbody>().AddForce(barrelEnd.forward * firePower, ForceMode.Impulse);
    }
}