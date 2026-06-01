using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
using System.IO;

public class TakeAPicture : MonoBehaviour
{
    [SerializeField] Image whereToShowScreenshot;
    public GameObject lastHit;
    public List<GameObject> hits = new List<GameObject>();
    Ray ray;
    public Vector3 boxSize;

    public float raycastTimer = 1;
    public float timer = -1;

    private void Update()
    {
        timer -= Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.P))
        {
            GameManager.Instance.screenShotHits.Clear();
            timer = raycastTimer;
            ray = new Ray(transform.position, transform.forward);
            
            StartCoroutine(TakeScreenshotAndShow());

            

        }
        CheckForColliders();
    }

    private IEnumerator TakeScreenshotAndShow()
    {
        yield return new WaitForEndOfFrame();

        Texture2D screenshot = ScreenCapture.CaptureScreenshotAsTexture();

        Texture2D newScreenshot = new Texture2D(screenshot.width, screenshot.height, TextureFormat.RGB24, false);
        
        newScreenshot.SetPixels(screenshot.GetPixels());
        newScreenshot.Apply();

        Destroy(screenshot);

        Sprite screenshotSprite = Sprite.Create(newScreenshot, new Rect(0,0, newScreenshot.width, newScreenshot.height), new Vector2(0.5f, 0.5f));

        
        whereToShowScreenshot.enabled = true;
        whereToShowScreenshot.sprite = screenshotSprite;
        GameManager.Instance.temporarySprite = screenshotSprite;
        
    }

    void CheckForColliders()
    {
        if (timer >= 0)
        {
            RaycastHit hit;
            if (Physics.BoxCast(transform.position, boxSize / 2, transform.forward, out hit))
            {

                lastHit = hit.transform.gameObject;
                GameManager.Instance.screenShotHits.Add(lastHit);
                lastHit.GetComponent<Collider>().enabled = false;


            }
        }
        
        //if (hits.Count > 0)
        //{
        //    Debug.Log("Collider detected");


        //    var script = hits[0].GetComponent<ColorTags>();
        //    var color = script.COLOR;
        //    var shape = script.SHAPE;

        //    Debug.Log(color + " + " + shape);
        //}
    }
            
    
}
