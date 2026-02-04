using UnityEngine;

class Health : IHealth
{
    int IHealth.Health => _currentHelth;
    public int Lives => _currentLives;

    private readonly HealthStats _stats;

    private int _currentHelth;
    private int _currentLives;

    public Health(HealthStats stats)
    {
        _stats = stats;

        _currentHelth = _stats.Health;
        _currentLives = _stats.Lives;
    }
    
    public void TakeHit(int damage)
    {
        _currentHelth-=damage;
        
        Debug.Log($"-taking hit, health remain:{_currentHelth}");

        if(_currentHelth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log($"-die, lieves remain:{_currentLives}");

        _currentLives--;
        _currentHelth = _stats.Health;
    }
}