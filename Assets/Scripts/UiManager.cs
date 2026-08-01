using UnityEngine;
using TMPro;

public class UiManager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text notiText;

    public static UiManager instance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShownotiText(string s)
    {
        notiText = s;
    }
}
