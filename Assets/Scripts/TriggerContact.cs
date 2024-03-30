using UnityEngine;

public class TriggerContact : MonoBehaviour
{
    [SerializeField] private GameObject chosenEnemy;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == chosenEnemy)
        {

            Player player = GetComponent<Player>();
            if (player != null)
            {
                player.TakeDamage(5);
                player.ShowStat();
            }

            Dragon dragon = chosenEnemy.GetComponent<Dragon>();
            if (dragon != null)
            {
                dragon.TakeDamage(10);

            }
        }
    }
}