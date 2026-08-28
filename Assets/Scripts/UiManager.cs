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

    public void Awake()
    {
        instance = this;
    }

    public void Start()
    {
        ShowHideRestartButton(false);
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
        instance.ShowHideRestartButton(false);
    }

    public void ShowHideRestartButton(bool flag)
    {
        restartButton.SetActive(flag);
    }
}