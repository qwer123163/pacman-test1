using UnityEngine;

public class ButtonTriger : MonoBehaviour
{
    public PlayerControl player;
    void OnTriggerEnter2D(Collider2D obj)
    {
        player.currHealth -= 5f;
        Destroy(gameObject);
    }
}