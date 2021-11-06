using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;

public class imageRecognitionExample : MonoBehaviour
{
    
    private ARTrackedImageManager ARTrackedImageManager;
    private void Awake()
    {
        ARTrackedImageManager = FindObjectOfType<ARTrackedImageManager>();
    }

    public void OnEnable()
    {
        ARTrackedImageManager.trackedImagesChanged += OnimageChanged;
    } 
    public void OnDisable()
    {
        ARTrackedImageManager.trackedImagesChanged -= OnimageChanged;
    }

    public void OnimageChanged(ARTrackedImagesChangedEventArgs args)
    {
         foreach (var trackedImage in args.added )
        {
            Debug.Log(trackedImage.name);
        }
    }

     
}
