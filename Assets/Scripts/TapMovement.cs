  /*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TapMovement : MonoBehaviour
{
  private Rigidbody2D rb;
    public float speed = 5.0f; // Velocidad de movimiento de la nave
    //**********
    private Transform player;

    //[SerializeField] PlayerController playerC;
    public TMP_Text LifeText;

    int index;

    //private GameManager GameManager;
    //public GameObject gameOverPanel;
    //int index;
    void Start()
    {
        //GameManager = GameManager.Instance;
        //index = PlayerPrefs.GetInt("JugadorIndex");

        player = GetComponent<Transform>();

        rb = GetComponent<Rigidbody2D>(); //***************

       // playerC.life = 3;
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

        //Acelerómetro

        // Obtén los datos del acelerómetro
        /*Vector3 acceleration = Input.acceleration;

        // Mueve la nave en función de los datos del acelerómetro
        Vector2 movement = new Vector2(acceleration.x, 0);
        rb.velocity = movement * speed;*/
   /* }

    // COLISIONES :)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log(GameManager.Instance.characters[index].life);
        Debug.Log(playerC.life);
        //Debug.Log(GameManager.characters[index].life + " :)");
        //if (collision.gameObject.CompareTag("Enemy"))
        if (collision.CompareTag("Enemy") && playerC.life > 0) // de crater
        {
            playerC.life--;
            //GameManager.characters[index].life
            //GameManager.characters[index].life--;
            LifeText.text = "Life: " + playerC.life; 
            //LifeText.text = "Life: " + GameManager.characters[index].life;

            collision.gameObject.SetActive(false);

            /*if (playerC.life <= 0)
            {
                Debug.Log("Game Over");
                
                Time.timeScale = 0f; // Pausar el juego
                gameOverPanel.SetActive(true);

                this.gameObject.SetActive(false); // character ***** new

                // Actualiza el texto de puntajes en el panel de Game Over
                gameOverPanel.transform.Find("ScoreGameOver").GetComponent<TextMeshProUGUI>().text = "Score: " + playerC.score;

                
            }*/
   /*
            if (playerC.life <= 0)
            {
                Debug.Log("Game Over");

                Time.timeScale = 0f; // Pausar el juego

                this.gameObject.SetActive(false); // character ***** new

                SceneManager.LoadScene("GameOver");

                // Guardar el puntaje en PlayerPrefs
                PlayerPrefs.SetInt("Score", playerC.score);
                PlayerPrefs.Save(); // Guardar los cambios en PlayerPrefs

                // Actualiza el texto de puntajes en el panel de Game Over
                // gameOverPanel.transform.Find("ScoreGameOver").GetComponent<TextMeshProUGUI>().text = "Score: " + playerC.score;


            } 
        }
        else
        {
            if (playerC.life <= 0)
            {
                Debug.Log("Game Over");

                Time.timeScale = 0f; // Pausar el juego

                this.gameObject.SetActive(false); // character ***** new

                SceneManager.LoadScene("GameOver");

                // Guardar el puntaje en PlayerPrefs
                PlayerPrefs.SetInt("Score", playerC.score); // de playerC.score
                PlayerPrefs.Save(); // Guardar los cambios en PlayerPrefs

                // Actualiza el texto de puntajes en el panel de Game Over
                // gameOverPanel.transform.Find("ScoreGameOver").GetComponent<TextMeshProUGUI>().text = "Score: " + playerC.score;

            }
        }
       
    }

}
*/