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

        Debug.Log;


    }

    private void OnCollsionExit(Collider collider)
    {
        rd.material.color = new Color32(210, 105, 30 , 255);
    }
}
