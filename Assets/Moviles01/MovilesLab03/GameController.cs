using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class GameController : MonoBehaviour
{
    [SerializeField] PlayerController player;
    private float tiempoEntrePuntos = 1.0f;
    public TMP_Text scoreText;

    //private GameManager GameManager; //********

   // int index;

    void Start()
    {
        //GameManager.characters[index].score = 0;

       // GameManager = GameManager.Instance;
       // index = PlayerPrefs.GetInt("JugadorIndex");

        InvokeRepeating("AddScore", tiempoEntrePuntos, tiempoEntrePuntos);

        // Recuperar el puntaje guardado en PlayerPrefs
        int score = PlayerPrefs.GetInt("Score");

        // Mostrar el puntaje en el texto del panel de Game Over
        scoreText.text = "Score: " + score;

        // Limpia el puntaje guardado en PlayerPrefs (si es necesario)
        PlayerPrefs.DeleteKey("Score");
        PlayerPrefs.Save(); // Guardar los cambios en PlayerPrefs
    }

    private void AddScore()
    {
        player.score++;
        //GameManager.characters[index].score++;
        scoreText.text = "Score : " + player.score;
        //scoreText.text = "Score : " + GameManager.characters[index].score;
    }

  

}
