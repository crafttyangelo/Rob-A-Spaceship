using UnityEngine;
using UnityEngine.InputSystem;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pauseOverlay;

    private bool isPaused;
    private float timeScaleBeforePause;

    private void Update()
    {
        Keyboard keyboard = Keyboard.current;
        if (keyboard == null || !keyboard.escapeKey.wasPressedThisFrame)
            return;

        if (isPaused)
            Resume();
        else
            Pause();
    }

    private void Pause()
    {
        isPaused = true;
        timeScaleBeforePause = Time.timeScale;
        Time.timeScale = 0f;
        pauseOverlay.SetActive(true);
    }

    public void Resume()
    {
        if (!isPaused)
            return;

        isPaused = false;
        Time.timeScale = timeScaleBeforePause;
        if (pauseOverlay != null)
            pauseOverlay.SetActive(false);
    }

    private void OnDisable()
    {
        Resume();
    }
}
