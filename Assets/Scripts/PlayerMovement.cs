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

    public GameObject gameOverPanel;

    //press
    private bool isDragging = false;
    private Vector3 offset;

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

            /*if (touch.phase == TouchPhase.Began)
            {
                // Convierte la posición del toque a coordenadas del mundo.
                Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
                touchPosition.z = 0;
                touchPosition.x = -7.26f;

                player.position = touchPosition;

               
            }*/
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    // ****  Comprobar si se ha tocado un objeto y configurar el arrastre 
                    // RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(touch.position), Vector2.zero);
                    // Convierte la posición del toque a coordenadas del mundo.
                    Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
                    touchPosition.z = 0;
                    touchPosition.x = -7.26f;

                    player.position = touchPosition;
                    //******
                    isDragging = true;
                    offset = transform.position - touchPosition;
                    offset.z = 0;
                    break;
                case TouchPhase.Moved:

                    if (isDragging)
                    {
                        Vector3 newPosition = Camera.main.ScreenToWorldPoint(touch.position) + offset;
                        transform.position = new Vector3(newPosition.x, newPosition.y, transform.position.z);
                    }
                    break;

                case TouchPhase.Ended:
                    // Finalizar el arrastre :)
                    isDragging = false;
                    break;
            }
        }
    }

    // COLISIONES :)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(playerC.score);
   
        if (collision.CompareTag("coin")) // de crater
        {
            playerC.score = playerC.score + 2;
            ScoreText.text = "Score: " + playerC.score;
            //LifeText.text = "Life: " + GameManager.characters[index].life;

            collision.gameObject.SetActive(false);

            // Actualiza el texto de puntajes en el panel de Game Over
            gameOverPanel.transform.Find("ScoreText").GetComponent<TextMeshProUGUI>().text = "Score: " + playerC.score;
        }
        if (collision.CompareTag("diamante")) // de crater
        {
            playerC.score = playerC.score + 5;
            ScoreText.text = "Score: " + playerC.score;
            //LifeText.text = "Life: " + GameManager.characters[index].life;

            collision.gameObject.SetActive(false);

            // Actualiza el texto de puntajes en el panel de Game Over
            gameOverPanel.transform.Find("ScoreText").GetComponent<TextMeshProUGUI>().text = "Score: " + playerC.score;

        }

    }
}
