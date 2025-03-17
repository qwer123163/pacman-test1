using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour

{ public float maxHealth = 100;//Здоровье игрока
    public float currHealth = 100;
    public Rigidbody2D rb; //С помощью Rigidbody2D будет осуществляться управление объектом
    public float jumpForce = 7000f; //Сила прыжка
    public float speed = 5f; // Скорость движения
    public int pilula = 0;
    //public PlayerControl player;
  //  void OnTriggerEnter2D(Collider2D obj)
  //  {
  //      player.pilula++;
  //      Destroy(gameObject);
  //  }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (currHealth > 0) //Управление объектом будет доступно, если здоровье выше нуля
        {
            float moveX = Input.GetAxis("Horizontal"); //Получение направления движения
            rb.MovePosition(rb.position + Vector2.right * moveX * speed * Time.deltaTime); //Изменение позиции
            if (Input.GetKey(KeyCode.W)) //Действие при нажатии стрелочки вверх

            {
                rb.AddForce(Vector2.up * jumpForce);
            }
            if (Input.GetKey(KeyCode.S)) //Действие при нажатии стрелочки вниз

            {
                rb.AddForce(Vector2.down * jumpForce); //Добавление силы прыжкка
            }
        }
        else
        {
            SceneManager.LoadScene("Game over");
        }
    }
}