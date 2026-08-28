using UnityEngine;

public class Finish : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Player p =other.GetComponent<Player>();

        if (p == null)
            return;

        Time.timeScale = 0f;

        Rigidbody rb = other.attachedRigidbody;
        if(rb != null)
        {
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }

        else
        Uimanager.instance.ShowNotiText($"You Win!!\nPoint:{p.Point}");
        Uimanager.instance.ShowHideRestartAndExit(true);
    }
}

