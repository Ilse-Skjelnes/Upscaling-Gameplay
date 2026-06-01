//using UnityEngine;
//using System.Collections.Generic;

//public class SaveTheScreenshots : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created 
//    public List<Sprite> ssSprites = new List<Sprite>();

//    private static SaveTheScreenshots instance;
//    public static SaveTheScreenshots Instance { get { return instance; } }

//    void Start()
//    {
//        DontDestroyOnLoad(gameObject);
//        if (instance != null)
//            Destroy(instance);
//        instance = this;
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if (GameManager.Instance != null)
//        { 
//            ssSprites = GameManager.Instance.screenShots;
//        }

//    }
//}
