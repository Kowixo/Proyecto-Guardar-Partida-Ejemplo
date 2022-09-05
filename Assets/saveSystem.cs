using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saveSystem : MonoBehaviour
{
    playerScript playerScr;
    healthScript healthScr;

    private void Awake() {
        playerScr = FindObjectOfType<playerScript>();
        healthScr = FindObjectOfType<healthScript>();
    }
    public void SaveGame(){
        Vector2 playerPos = playerScr.GetPosition();
        int playerHealth = healthScr.GetHealth();

        PlayerPrefs.SetFloat("posX", playerPos.x);
        PlayerPrefs.SetFloat("posY", playerPos.y);
        PlayerPrefs.SetInt("health", playerHealth);
    }

    public void LoadGame(){
        Vector2 playerPos = new Vector2(PlayerPrefs.GetFloat("posX"), PlayerPrefs.GetFloat("posY"));
        int playerHealth = PlayerPrefs.GetInt("health");

        playerScr.SetPosition(playerPos);
        healthScr.SetHealth(playerHealth);
    }
}
