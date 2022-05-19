using UnityEngine;

public class HealthSystem : MonoBehaviour {
    public int MaxHealth = 10;
    private int _health;

    private void Start()
    {
        _health = MaxHealth;
    }

    public int GetHealth()
    {
        return _health;
    }

    public void TakeDamage(int damageAmt)
    {
        _health -= damageAmt;

        if (_health <= 0)
        {
            UnityEngine.Debug.Log("Player has died");
        }
    }
}
