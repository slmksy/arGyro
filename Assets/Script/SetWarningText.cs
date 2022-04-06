using Assets.Script;
using UnityEngine;

public class SetWarningText : MonoBehaviour
{
    #region Contants

    #endregion

    #region Fields

    #endregion

    #region Constructors
    public SetWarningText()
    {

    }

    #endregion

    #region Properties

    #endregion

    #region Public Methods

    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        var uiText = gameObject.GetComponent<UnityEngine.UI.Text>();
        if (TrackingModel.Instance.IsMarkerTracking)
        {
            uiText.text = "İşaretçi takip ediliyor...";
            uiText.color = Color.green;
        }
        else
        {
            uiText.text = "İşaretçi kaybedilmiştir!";
            uiText.color = Color.red;
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
