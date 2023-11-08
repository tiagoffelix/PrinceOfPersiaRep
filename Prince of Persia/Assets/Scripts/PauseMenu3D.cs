using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu3D : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenuCanvas;

    [SerializeField] private GameObject healthCanvas;

    [SerializeField] private GameObject materialCanvas;
    [SerializeField] private GameObject controlsCanvas;

    private bool isPaused;

    [SerializeField] private Button pauseButton;

    [SerializeField] private GameObject timeOverCamera;
    [SerializeField] private GameObject timeOverCanvas;
    [SerializeField] private TextMeshProUGUI timeOverText;

    [SerializeField] private PlayerStats playerStats;

    [SerializeField] private PlayerMovement player;

    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private Image timerImage;

    [SerializeField] private GameObject shop;

    [SerializeField] private GameObject bedInteractable;

    [SerializeField] private AudioSource buttonSound;

    [SerializeField] private AudioSource firstDaySound;

    [SerializeField] private AudioSource endingSound;

    private float totalDuration;
    private int startHour;
    private int endHour;

    private void Start()
    {
        isPaused = false;
        totalDuration = 90f;
        startHour = 9;
        endHour = 20;
        timeOverCamera.SetActive(false);

        if (playerStats.BossDead)
        {
            endingSound.Play();
        }
    }
    void Update()
    {
        if (!playerStats.BossDead)
        {
     
                pauseButton.gameObject.SetActive(false);
                materialCanvas.SetActive(false);
                pauseMenuCanvas.SetActive(false);
                timerImage.enabled = false;
                foreach (Transform child in timerImage.GetComponent<Transform>())
                {
                    child.gameObject.SetActive(false);
                }
                timeOverCamera.SetActive(true);
                timeOverCanvas.SetActive(true);
                timeOverText.text = "day " + playerStats.Night + " ended";
            

        }
        else 
        {
            timerImage.gameObject.SetActive(false);
            materialCanvas.SetActive(false);
            healthCanvas.SetActive(false);
            bedInteractable.SetActive(true);
        }

        if (isPaused)
        {
            shop.SetActive(false);
            Time.timeScale = 0f;
            Cursor.visible = true;
            timerImage.gameObject.SetActive(false);
            
            GameObject blueprint = GameObject.FindGameObjectWithTag("Blueprint");
            
            Destroy(blueprint);

        }
        else if (AllShopObjectsNotActive())
        {
            Cursor.visible = false;
            Time.timeScale = 1f;
            timerImage.gameObject.SetActive(true);
        }
        else 
        {
            Cursor.visible = true;
        }

        if (controlsCanvas.activeSelf && !isPaused)
        {
            controlsCanvas.SetActive(isPaused);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePauseMenu();
        }
    }

    private bool AllShopObjectsNotActive()
    {
        GameObject[] shopObjects = GameObject.FindGameObjectsWithTag("Shop");
        foreach (GameObject shopObject in shopObjects)
        {
            if (shopObject.activeSelf)
            {
                return false; // At least one shop object is active, so return false
            }
        }

        return true; // None of the shop objects are active, so return true
    }

    public void TogglePauseMenu()
    {
        buttonSound.Play();
        isPaused = !isPaused;
        pauseMenuCanvas.SetActive(isPaused);
        materialCanvas.SetActive(!isPaused);
    }
    public void MainMenu()
    {
        isPaused = false;
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
