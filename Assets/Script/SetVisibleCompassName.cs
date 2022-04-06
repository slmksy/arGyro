using Assets.Script;
using System;
using UnityEngine;

public class SetVisibleCompassName : MonoBehaviour
{
    #region Contants

    #endregion

    #region Fields

    #endregion

    #region Constructors
    public SetVisibleCompassName()
    {

    }

    #endregion

    #region Properties

    #endregion

    #region Public Methods

    // Start is called before the first frame update
    public void Start()
    {
        gameObject.SetActive(false);
        TrackingModel.Instance.OnTrackingChanged += OnTrackingChanged;
    }

    // Update is called once per frame
    public void Update()
    {

    }

    #endregion

    #region Private Methods

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
