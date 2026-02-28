using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    public Slider sliderHP;

    public void SetSlider(float amount) {
        sliderHP.value = amount;
    }

    public void SetSliderMax(float amount) {
        sliderHP.maxValue = amount;
        SetSlider(amount);
    }
    
}