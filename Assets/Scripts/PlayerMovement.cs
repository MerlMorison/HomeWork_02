using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 0.2f;

    private void Update()
    {
        Move();
    }
    private void Move()
    {

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-moveSpeed, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(moveSpeed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0f, 0f, moveSpeed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, 0f, -moveSpeed);
        }
    }
}