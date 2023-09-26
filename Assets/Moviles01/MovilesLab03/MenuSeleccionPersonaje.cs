using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuSeleccionPersonaje : MonoBehaviour
{
    private int index;

    [SerializeField] private Image _image;

    [SerializeField] private TextMeshProUGUI name;

    private GameManager GameManager;

    void Start()
    {
        Time.timeScale = 0f; // Pausar el juego
        GameManager = GameManager.Instance;

        index = PlayerPrefs.GetInt("JugadorIndex");

        if(index > GameManager.characters.Count - 1)
        {
            index = 0;
        }

        ChangeScreen();
    }

   private void ChangeScreen()
   {
       PlayerPrefs.SetInt("JugadorIndex", index);
        _image.sprite = GameManager.characters[index].image;
        name.text = GameManager.characters[index].name;
   }

    public void NextPersonaje()
    {
        if(index == GameManager.characters.Count - 1)
        {
            index = 0;
        }
        else
        {
            index += 1;
        }

        ChangeScreen();
    }
    public void AnteriorPersonaje()
    {
        if (index == 0 )
        {
            index = GameManager.characters.Count - 1;
        }
        else
        {
            index -= 1;
        }

        ChangeScreen();
    }

    public void IniciarJuego()
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //SceneManager.LoadScene("MovilesLab01");
        //Time.timeScale = 1f; // Pausar el juego
    }

}
