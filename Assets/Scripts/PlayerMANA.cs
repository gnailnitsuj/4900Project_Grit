using UnityEngine;
using UnityEngine.UI;

public class PlayerMANA : MonoBehaviour
{
    public Slider sliderMP;

    public void SetSlider(float amount) {
        sliderMP.value = amount;
    }

    public void SetSliderMax(float amount) {
        sliderMP.maxValue = amount;
        SetSlider(amount);
    }
}
