using UnityEngine;

public class TurnTutorialKeysOff : MonoBehaviour
{

    public GameObject W;
    public GameObject A;
    public GameObject S;
    public GameObject D;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TurnOffKeys();
    }

    public void TurnOffKeys()
    {
        if (Input.GetKeyDown(KeyCode.W))
            W.SetActive(false);
        if (Input.GetKeyDown(KeyCode.A))
            A.SetActive(false);
        if (Input.GetKeyDown(KeyCode.S))
            S.SetActive(false);
        if (Input.GetKeyDown(KeyCode.D))
            D.SetActive(false);
    }
}
