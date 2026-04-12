using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject container;

    void Update() {
        if (Input.GetKeyDown("escape")) {
            container.SetActive(true);
            // Stop all action
            Time.timeScale = 0;
            Debug.Log("paused");
        }
    }

    public void resumeBtn() {
        container.SetActive(false);
        Time.timeScale = 1;
    }

    public void titleBtn() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Start");
    }

    void Start () {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
