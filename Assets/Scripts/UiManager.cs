using UnityEngine;
using TMPro;

public class UiManager : MonoBehaviour
{
    public static UiManager instance;

    [SerializeField]
    private TMP_Text notiText;

    [SerializeField]
    private GameObject restartButton;

    [SerializeField]
    private Player player;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {

    }

    void Update()
    {

    }

    public void ShowNotiText(string s)
    {
        notiText.text = s;
    }

    public void ResartGame()
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