using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private Transform player;

    [SerializeField] PlayerController playerC;
    public TMP_Text LifeText;

    public TMP_Text ScoreText;

    void Start()
    {

        player = GetComponent<Transform>();

        // rb = GetComponent<Rigidbody2D>(); //***************

        playerC.life = 3;
        playerC.score = 0;
        Time.timeScale = 1f; // Reanudar el juego
    }

    void Update()
    {

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                // Convierte la posición del toque a coordenadas del mundo.
                Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
                touchPosition.z = 0;
                touchPosition.x = -7.26f;

                player.position = touchPosition;


            }
        }
    }

    // COLISIONES :)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(playerC.score);
   
        if (collision.CompareTag("coin")) // de crater
        {
            playerC.score++;
            ScoreText.text = "Score: " + playerC.score;
            //LifeText.text = "Life: " + GameManager.characters[index].life;

            collision.gameObject.SetActive(false);

            // Actualiza el texto de puntajes en el panel de Game Over
            //gameOverPanel.transform.Find("ScoreGameOver").GetComponent<TextMeshProUGUI>().text = "Score: " + playerC.score;


        }

    }
}
