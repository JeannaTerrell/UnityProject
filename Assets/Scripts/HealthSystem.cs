using UnityEngine;
using UnityEngine.SceneManagement;

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

    private void Update()
    {
        var myPos = transform.position;
        if (myPos.y < -4.5)
        {
            _health = 0;
        }

        if (_health <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }

    public void TakeDamage(int damageAmt)
    {
        _health -= damageAmt;
    }
}
