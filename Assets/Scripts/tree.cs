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
        if (rd != null) ;
    }

    private void OnCollisionEnter(Collision collision)
    {
        rd.material.color = Color.red;
        Player player = collision.gameObject.GetComponent<Player>();

        player.HP -= 15;

        UiManager.instance.ShownotiText($"Hurt -15\nHP: {player.HP}");

        if(player.HP <= 0 )
        {
            player.HP = 0;
        }


    }

    private void OnCollsionExit(Collision collision)
    {
        rd.material.color = new Color32(210, 105, 30 , 255);
    }
}
