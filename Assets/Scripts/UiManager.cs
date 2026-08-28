using UnityEngine;
using TMPro;

public class Uimanager : MonoBehaviour
{

    public static Uimanager instance;

    [SerializeField]
    private TMP_Text notiText;

    [SerializeField]
    private GameObject restartButton;

    [SerializeField]
    private Player player;

    [SerializeField]
    private GameObject exitButton;

    public void Awake()
    {
        instance = this;
    }

    public void Start()
    {
        ShowHideRestartAndExit(false);
    }

    public void ShowNotiText(string s)
    {
        notiText.text = s;
    }

    public void RestartGame()
    {
        player.transform.position = new Vector3(0.1f, 64.5f, -62.5f);
        player.HP = 100;
        ShowNotiText("Restart");
        Time.timeScale = 1f;
        instance.ShowHideRestartAndExit(false);
    }

    public void ShowHideRestartAndExit(bool flag)
    {
        restartButton.SetActive(flag);
        exitButton.SetActive(flag);
    }

    public void Exit()
    {
        Time.timeScale = 1f;
        Application.Quit();
    }
}