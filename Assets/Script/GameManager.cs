using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Class Yang Mengatur Sebagian Besar Fitur Game
public class GameManager : MonoBehaviour
{
    private Rigidbody2D rb;
    private Transform respawnPosition;
    private bool died = false;
    public GameObject gameOverUi;
    public GameObject levelCompleteUi;
    [SerializeField] private float delay = 2f;

    //Fungsi Disaat Player Mati
    public void GameOver()
    {
        if(died==false)
        {
            gameOverUi.SetActive(true);
            died = true;
            Invoke("Restart",delay);
        }
     
    }

    //Fungsi  Untuk Load Level Selanjutnya
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //Fungsi Menampilkan UI Level Comlete
    public void LevelComplete()
    {
        levelCompleteUi.SetActive(true);  
    }

    //Fungsi Untuk Respawn Disaat Player Mati ke tempat yang sudah Ditentukan
    void Respawn(Rigidbody2D col)
    {
        movement move = new movement();
        died = false;
        col.transform.position = respawnPosition.position;
        move.enabled = true;  
    }
    
    //Fungsi Untuk Mengulang Level Dari Awal
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
