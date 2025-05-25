using UnityEngine;

public class CannonBall : MonoBehaviour 
{
    [Header("Effects")]
    public GameObject hitEffectPrefab; // Изменили на префаб GameObject
    public float destroyDelay = 0.5f;

    void OnCollisionEnter(Collision collision) 
    {
        // Создаем эффект попадания
        if (hitEffectPrefab != null)
        {
            GameObject effect = Instantiate(hitEffectPrefab, transform.position, Quaternion.identity);
            effect.GetComponent<ParticleSystem>().Play(); // Явный запуск
            Destroy(effect, 1f); // Удаляем через 1 секунду
        }

        // Разрушаемый объект
        if (collision.gameObject.CompareTag("Destructible")) 
        {
            Destroy(collision.gameObject);
        }

        // Уничтожаем шар
        Destroy(gameObject, destroyDelay);
    }
}