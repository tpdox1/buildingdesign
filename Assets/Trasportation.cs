using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller; // Ссылка на компонент Character Controller
    public float moveSpeed = 5f; // Скорость движения
    public float gravity = -9.81f; // Гравитация
    public float jumpHeight = 2f; // Высота прыжка

    private Vector3 velocity; // Вектор скорости
    private bool canMove = false; // Флаг, позволяющий двигаться

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        if (canMove) 
        {
            Vector3 moveDirection = transform.right * horizontalInput + transform.forward * verticalInput;

            // Применяем гравитацию
            velocity.y += gravity * Time.deltaTime;

            // Обработка прыжка
            if (controller.isGrounded && Input.GetButtonDown("Jump"))
            {
                velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            }

            // Перемещение
            controller.Move(moveDirection * moveSpeed * Time.deltaTime);

            // Применение скорости
            controller.Move(velocity * Time.deltaTime);
        }
    }

    void OnMouseDown()
    {
        canMove = true; 
    }
}
