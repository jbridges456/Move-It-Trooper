using UnityEngine;

public class DeathDestroy : AbstractDeath
{
    public override void Die()
    {
        Destroy(gameObject);
    }
}
