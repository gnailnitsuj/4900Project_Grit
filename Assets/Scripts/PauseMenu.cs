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
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    public void resumeBtn() {
        container.SetActive(false);
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void titleBtn() {
        container.SetActive(false);
        Time.timeScale = 1;
        UnityEngine.SceneManagement.SceneManager.LoadScene("Start");
    }
}
