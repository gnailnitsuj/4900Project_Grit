using UnityEngine;
using UnityEngine.UI;

public class PlayerSTAM : MonoBehaviour
{
   public Slider sliderSTAM;

    public void SetSlider(float amount) {
        sliderSTAM.value = amount;
    }

    public void SetSliderMax(float amount) {
        sliderSTAM.maxValue = amount;
        SetSlider(amount);
    }
}
