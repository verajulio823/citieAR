using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;
using System;

public class TomarFoto : MonoBehaviour {

    private RawImage imagenCam;
    public GameObject camera;
    //public RawImage imagenShot;
    private WebCamTexture webCamTexture;
    private string fileName = "foto";
    private string savePath = "/mnt/sdcard/Android/data/com.citie.realidadaumentada/"; 
    private int captureCounter;

    private byte[] bytes;
    private Texture2D snap;

	// Use this for initialization
	void Start () {
        //webCamTexture = camera.GetComponent<WebCamTexture>();//new WebCamTexture();
       // Renderer renderer= camera.GetComponent<Renderer>();
        
        Debug.Log("HASTA ACA LLEGO");
       // imagenCam.texture = renderer.material.mainTexture;
       // webCamTexture.Play();
        
	
	}

    
    public void ButtonSnapShot() {
        Console.WriteLine("HOLA MUNDO PENDEJOS");
        Application.CaptureScreenshot("Screenshot3.png");
    
    }

    
}
