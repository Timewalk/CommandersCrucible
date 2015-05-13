using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WindowLoginController : MonoBehaviour {

    CanvasGroup canvas;

    void Awake()
    {
        canvas = this.GetComponent<CanvasGroup>();
        canvas.alpha = 0;
        canvas.interactable = false;
        canvas.blocksRaycasts = false;
    }

    public void OnClick()
    {
        if (canvas.alpha == 0)
            canvas.alpha = 1;
        else
            canvas.alpha = 0;

        if (canvas.interactable == true)
            canvas.interactable = false;
        else
            canvas.interactable = true;

        if (canvas.blocksRaycasts == true)
            canvas.blocksRaycasts = false;
        else
            canvas.blocksRaycasts = true;
    }

}
