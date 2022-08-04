using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class CloudRecoEventHandler : MonoBehaviour
{
    CloudRecoBehaviour mCloudRecoBehaviour;
    ImageTargetBehaviour mImageTargetBehaviour;
    Tracker mImageTracker;


    // Start is called before the first frame update
    void Awake()
    {
        mCloudRecoBehaviour = GetComponent<CloudRecoBehaviour>();
        if (mCloudRecoBehaviour)
        {
            mCloudRecoBehaviour.RegisterOnInitializedEventHandler(OnInitialized);
            mCloudRecoBehaviour.RegisterOnNewSearchResultEventHandler(OnNewSearchResult);
            mCloudRecoBehaviour.RegisterOnStateChangedEventHandler(OnStateChanged);
        }

    }

    private void OnInitialized(TargetFinder targetFinder)
    {
        
    }

    private void OnStateChanged(bool scanning)
    {

    }

    private void OnNewSearchResult(TargetFinder.TargetSearchResult targetSearchResult)
    {
        Debug.Log("<color=blue>OnNewSearchResult(): </color>" + targetSearchResult.TargetName);

        if (targetSearchResult.UniqueTargetId == null)
            Debug.Log("Target metadata not available.");
        else
        {
            Debug.Log("TargetName: " + targetSearchResult.TargetName);
            Debug.Log("UniqueTargetId: " + targetSearchResult.UniqueTargetId);
        }

        mCloudRecoBehaviour.enabled = false;

        
    }


}
