using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour

{ public float maxHealth = 100;//�������� ������
    public float currHealth = 100;
    public Rigidbody2D rb; //� ������� Rigidbody2D ����� �������������� ���������� ��������
    public float jumpForce = 7000f; //���� ������
    public float speed = 5f; // �������� ��������
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
        if (currHealth > 0) //���������� �������� ����� ��������, ���� �������� ���� ����
        {
            float moveX = Input.GetAxis("Horizontal"); //��������� ����������� ��������
            rb.MovePosition(rb.position + Vector2.right * moveX * speed * Time.deltaTime); //��������� �������
            if (Input.GetKey(KeyCode.W)) //�������� ��� ������� ��������� �����

            {
                rb.AddForce(Vector2.up * jumpForce);
            }
            if (Input.GetKey(KeyCode.S)) //�������� ��� ������� ��������� ����

            {
                rb.AddForce(Vector2.down * jumpForce); //���������� ���� �������
            }
        }
        else
        {
            SceneManager.LoadScene("Game over");
        }
    }
}