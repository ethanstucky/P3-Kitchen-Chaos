using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField] private Button playButton;
    [SerializeField] private Button quitButton;

    private void Awake()
    {
        playButton.onClick.AddListener(() =>
        {
            // Click
            Loader.Load(Loader.Scene.gameScene);
        });
        
        quitButton.onClick.AddListener(Application.Quit);

        Time.timeScale = 1f;
    }
    
    
}
