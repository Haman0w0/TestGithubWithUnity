using UnityEngine;

public class control : MonoBehaviour
{
    public GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w"))
        {
            player.transform.Translate(0, 0, 0.5f);
        }
        if(Input.GetKey("s"))
        {
            player.transform.Translate(0, 0, -0.5f);
        }
        if(Input.GetKey("a"))
        {
            player.transform.Translate(-0.5f, 0, 0);
        }
        if(Input.GetKey("d"))
        {
            player.transform.Translate(0.5f, 0, 0);
        }
        if(Input.GetKey(KeyCode.Space))
        {
            player.transform.Translate(0, 0.5f, 0);
        }
        if(Input.GetKey(KeyCode.LeftControl))
        {
            player.transform.Translate(0, -0.5f, 0);
        }
    }
}
