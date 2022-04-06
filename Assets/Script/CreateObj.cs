using UnityEngine;

namespace Assets.Script
{
    public class CreateObj : MonoBehaviour
    {
        #region Contants

        #endregion

        #region Fields

        public GameObject compassCam;

        #endregion

        #region Constructors

        public CreateObj() 
        {

        }

        #endregion

        #region Properties

        #endregion

        #region Public Methods
        public void Update()
        {
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            {
                Vector3 fingerPos = Input.GetTouch(0).position;
                fingerPos.z = compassCam.transform.position.z;
                Vector3 objPos = Camera.allCameras[0].ScreenToWorldPoint(fingerPos);

                Instantiate(compassCam, objPos, Quaternion.identity);

            }
        }

        #endregion

        #region Private Methods

        #endregion

        #region Protected Methods

        #endregion

        #region Events

        #endregion

    }
}
