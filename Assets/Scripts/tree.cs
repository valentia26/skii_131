using System;
using UnityEngine;

public class tree : MonoBehaviour
{
    private MeshRenderer rd;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rd = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        Player player = collision.gameObject.GetComponent<Player>();


        if (player == null)
        {
            return;
        }
       
        rd.material.color = Color.red;

        player.HP -= 15;
        Uimanager.instance.ShowNotiText($"Hurt -15\nHP: {player.HP}");

        if (player.HP <= 0)
        {
            player.HP = 0;
            Time.timeScale = 0f;
            Uimanager.instance.ShowNotiText($" You are dead!!!\nPoints:{player.Point}");
            Uimanager.instance.ShowHideRestartButton(true);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        rd.material.color = Color.brown;
    }
}