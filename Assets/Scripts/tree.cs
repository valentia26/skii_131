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

        // ถ้าสิ่งที่ชนไม่ใช่ผู้เล่น ให้ออกจากฟังก์ชันทันที
        if (player == null)
            return;

        //// ถ้าผู้เล่นยังอยู่ในช่วงอมตะ (เพิ่งโดนไปหมาดๆ) ไม่ต้องลด HP ซ้ำ
        //if (!player.CanTakeDamage())
        //    return;

        rd.material.color = Color.red;

        player.HP -= 15;
        UiManager.instance.ShowNotiText($"Hurt -15\nHP: {player.HP}");

        if (player.HP <= 0)
        {
            player.HP = 0;
            Time.timeScale = 0f;
            UiManager.instance.ShowNotiText($" You are dead!!!\nPoints:{player.Point}");
            UiManager.instance.ShowHideRestartButton(true);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        rd.material.color = new Color32(210, 105, 30, 255);
    }
}