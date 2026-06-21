using UnityEngine;
using System.Collections.Generic;

public class SpawnNewBook : MonoBehaviour
{

    public List<GameObject> books = new List<GameObject>();
    public int bookindex;

    private void Start()
    {
        
    }

    public void ActivateBook()
    {
        books[bookindex].SetActive(true);
        bookindex++;
    }
}
