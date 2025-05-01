using UnityEngine;

public class CombatSystem : MonoBehaviour
{
    public float maxHP = 100f;
    public float currentHP;
    public float attackPower = 10f;

    void Start()
    {
        currentHP = maxHP;
    }

    void OnCollisionStay(Collision collision)
    {
        CombatSystem enemy = collision.gameObject.GetComponent<CombatSystem>();
        if (enemy != null)
        {
            enemy.TakeDamage(attackPower * Time.deltaTime);
        }
    }

    public void TakeDamage(float amount)
    {
        currentHP -= amount;
        if (currentHP <= 0)
        {
            Destroy(gameObject);
        }
    }
}
