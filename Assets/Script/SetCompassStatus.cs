using Assets.Script;
using System;
using UnityEngine;

public class SetCompassStatus : MonoBehaviour
{
    #region Contants

    private const float TreshOld = 1.0f;

    #endregion

    #region Fields


    public bool IsCamCompass;
    public GameObject imageTarget;

    #endregion

    #region Constructors
    public SetCompassStatus()
    {

    }

    #endregion

    #region Properties

    #endregion

    #region Public Methods

    // Start is called before the first frame update
    public void Start()
    {
        Input.compass.enabled = true;
        gameObject.SetActive(false);
        TrackingModel.Instance.OnTrackingChanged += OnTrackingChanged;
    }

    // Update is called once per frame
    public void Update()
    {
        if (IsCamCompass)
        {
            ProcessCamCompass();
        }
        else
        {
            ProcessMarkerCompass();
        }
    }

    #endregion

    #region Private Methods

    private void ProcessCamCompass()
    {
        var currentNorth = transform.eulerAngles.y;
        var compassMagneticNorth = -Input.compass.magneticHeading;

        if (Math.Abs(compassMagneticNorth - currentNorth) > TreshOld)
        {
            transform.rotation = Quaternion.Euler(90, compassMagneticNorth, 0);
        }
    }

    private void ProcessMarkerCompass()
    {
        var currentNorth = transform.eulerAngles.y;
        var markerRotY = imageTarget.transform.eulerAngles.y;

        Debug.LogWarning("markerRotY" + markerRotY);
        if (Math.Abs(markerRotY - currentNorth) > TreshOld)
        {
            transform.rotation = Quaternion.Euler(90, -Input.compass.magneticHeading - markerRotY, 0);
        }
    }

    #endregion

    #region Protected Methods

    #endregion

    #region Events
    private void OnTrackingChanged(object sender, EventArgs e)
    {
        var isTracking = TrackingModel.Instance.IsMarkerTracking;
        gameObject.SetActive(isTracking);
    }

    #endregion
}
