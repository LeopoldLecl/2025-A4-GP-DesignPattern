using Tanks.Complete;
using UnityEngine;
using UnityEngine.UI;

public class HealthUIControllerScript : MonoBehaviour
{

    [SerializeField] Slider m_Slider;                             // The slider to represent how much health the tank currently has.
    [SerializeField] Image m_FillImage;                           // The image component of the slider.
    [SerializeField] Color m_FullHealthColor = Color.green;    // The color the health bar will be when on full health.
    [SerializeField] Color m_ZeroHealthColor = Color.red;

    TankHealth tankHealth; 

    private void Awake()
    {
        tankHealth = GetComponent<TankHealth>();
    }

    private void Start()
    {
        SetHealthUI();
    }

    private void OnEnable()
    {
        tankHealth.OnHealthUpdate += SetHealthUI;
    }

    private void OnDisable()
    {
        tankHealth.OnHealthUpdate -= SetHealthUI;
    }


    private void SetHealthUI()
    {
        float currentHealth = tankHealth.GetCurrentHealth();
        float maxHealth = tankHealth.GetMaxHealth();
        m_Slider.value = currentHealth;

        m_FillImage.color = Color.Lerp(m_ZeroHealthColor, m_FullHealthColor, currentHealth / maxHealth);
    }
}
