using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LoadScene : MonoBehaviour
{

    public TMP_Text scoreText;

    void start()
    {
        // Recuperar el puntaje guardado en PlayerPrefs
        int score = PlayerPrefs.GetInt("Score");

        // Mostrar el puntaje en el texto del panel de Game Over
        scoreText.text = "Score: " + score;

        // Limpia el puntaje guardado en PlayerPrefs (si es necesario)
        PlayerPrefs.DeleteKey("Score");
        PlayerPrefs.Save(); // Guardar los cambios en PlayerPrefs
    }

    public void RestartGame()
    {
        Debug.Log("RestartGame method called."); // Agrega esta línea
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1); //gameover a Movil1
    }
}
