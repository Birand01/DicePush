using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    public Text winText;
    public bool gameOver = false;
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("EnemyWinWall"))
        {
            winText.gameObject.SetActive(true);
            winText.text = "ENEMY WIN!";
            gameOver = true;
        }
        else if(collision.gameObject.CompareTag("PlayerWinWall"))
        {
            winText.gameObject.SetActive(true);
            winText.text = "PLAYER WIN!";
            gameOver = true;
        }
    }
}
