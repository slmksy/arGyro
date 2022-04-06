using System;

namespace Assets.Script
{
    public class TrackingModel
    {
        #region Contants

        #endregion

        #region Fields

        private static TrackingModel instance;
        public event EventHandler OnTrackingChanged;
        private bool isMarkerTracking;

        #endregion

        #region Constructors

        private TrackingModel()
        {

        }

        #endregion

        #region Properties

        public static TrackingModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TrackingModel();
                }

                return instance;
            }
        }

        public bool IsMarkerTracking
        {
            get
            {
                return isMarkerTracking;
            }
            set
            {
                if (isMarkerTracking == value)
                {
                    return;
                }

                isMarkerTracking = value;

                if (OnTrackingChanged != null)
                {
                    OnTrackingChanged.Invoke(this, null);
                }
            }
        }

        #endregion

        #region Public Methods

        #endregion

        #region Private Methods

        #endregion

        #region Protected Methods

        #endregion

        #region Events

        #endregion
    }
}
