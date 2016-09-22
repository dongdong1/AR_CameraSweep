/*============================================================================== 
 * Copyright (c) 2015 Qualcomm Connected Experiences, Inc. All Rights Reserved. 
 * ==============================================================================*/
using UnityEngine;
using System.Collections;


public class ModelSwap : MonoBehaviour 
{
    private GameObject mDefaultModel;
    private GameObject mExtTrackedModel;
    private GameObject mActiveModel = null;
    private TrackableSettings mTrackableSettings = null;

	void Start () 
    {
        //if(this.name=="ImageTargetBall")
            mDefaultModel = this.transform.FindChild("pokemon").gameObject;
        /*
        else if(this.name=="ball")
            mDefaultModel = this.transform.FindChild("ball").gameObject;
        else
            mDefaultModel = this.transform.FindChild("teapot").gameObject;
         * */

        mExtTrackedModel = this.transform.FindChild("tower").gameObject;
        mActiveModel = mDefaultModel;
        mTrackableSettings = FindObjectOfType<TrackableSettings>();

        //choose model by default
        mDefaultModel.SetActive(true);
        mExtTrackedModel.SetActive(false);
        mActiveModel = mDefaultModel;
    }
    
    void Update () 
    {
        /*
        if (mTrackableSettings.IsExtendedTrackingEnabled() && (mActiveModel == mDefaultModel))
        {
            // Switch 3D model to tower
            mDefaultModel.SetActive(false);
            mExtTrackedModel.SetActive(true);
            mActiveModel = mExtTrackedModel;
        }
        else if (!mTrackableSettings.IsExtendedTrackingEnabled() && (mActiveModel == mExtTrackedModel))
        {
            // Switch 3D model to teapot
            mExtTrackedModel.SetActive(false);
            mDefaultModel.SetActive(true);
            mActiveModel = mDefaultModel;
        }
        */
    }
}
