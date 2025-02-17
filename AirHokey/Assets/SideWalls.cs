using UnityEngine;
using System.Collections;
public class SideWalls : MonoBehaviour {

    // Verifica colisões da bola nas paredes
    void OnTriggerEnter2D (Collider2D hitInfo) {
        if (hitInfo.tag == "Bolla")
        {
            string wallName = transform.name;
            GameManager.Score(wallName);
            hitInfo.gameObject.SendMessage("RestartGame", null, SendMessageOptions.RequireReceiver);
        }
    }
}
