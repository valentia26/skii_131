using System;
using UnityEngine;

public class Flag : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Player player = other.gameObject.GetComponent<Player>();

        if (player == null)
            return;

        player.Point += 10;

        Uimanager.instance.ShowNotiText($"+10/point\nPoints: {player.Point}");
        Destroy(gameObject);
    }
}