using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Class Main Menu
public class Menu : MonoBehaviour
{
   
    //Fungsi Yang Dijalanka Ketika Kita Menekan Toombol Play
    private void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //Fungsi Yang Dijalanka Ketika Kita Menekan Toombol Quit
    private void QuitGame()
    {
        Application.Quit();
    }
}
