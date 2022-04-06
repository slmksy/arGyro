using Assets.Script;
using UnityEngine;
using Vuforia;

public class TrackingHandler : MonoBehaviour, ITrackableEventHandler
{
    #region Contants

    #endregion

    #region Fields

    private TrackableBehaviour trackableBehaviour;

    #endregion

    #region Constructors
    public TrackingHandler()
    {

    }

    #endregion

    #region Properties

    #endregion

    #region Public Methods
    public void Start()
    {
        trackableBehaviour = GetComponent<TrackableBehaviour>();
        if (trackableBehaviour)
        {
            trackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    #endregion

    #region Private Methods
    private void OnTrackingFound()
    {
        TrackingModel.Instance.IsMarkerTracking = true;
    }
    private void OnTrackingLost()
    {
        TrackingModel.Instance.IsMarkerTracking = false;
    }

    #endregion

    #region Protected Methods

    #endregion

    #region Events
    public void OnTrackableStateChanged(
      TrackableBehaviour.Status previousStatus,
      TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            OnTrackingFound();
        }
        else
        {
            OnTrackingLost();
        }
    }

    #endregion  
}
