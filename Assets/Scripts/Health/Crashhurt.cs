using UnityEngine;

public class Crashhurt : MonoBehaviour
{
    public float Amountdamage = 10;
    private void OnCollisionEnter(Collision collision)
    {
      if ( collision.gameObject.TryGetComponent<Health>(out Health component))
        {
            component.Damage(Amountdamage);
        }
    }
}
