using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthShip : MonoBehaviour {

    public int startShield = 100;
    public int startLife = 100;
    public int actualShield;
    public int actualLife;
    public Slider shieldSlider;
    public Slider lifeSlider;
    public Image damageImage;
    public float flashSpeed = 4f;
    public Color flashLifeColour = new Color(1f, 0f, 0f, 0.1f);
    public Color flashShieldColour = new Color(1f, 0f, 0f, 0.1f);

    bool isDead;
    bool damagedShield;
    bool damagedLife;

    // Use this for initialization
    void Start ()
    {
        actualShield = startShield;
        actualLife = startLife;
    }
	
	// Update is called once per frame
	void Update () {
        if (damagedShield) {
            damageImage.color = flashShieldColour;
        }
        else if (damagedLife)
        {
            damageImage.color = flashLifeColour;
        }
        else {
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }

        damagedShield = false;
        damagedLife = false;
    }

    public void TakeDamage (int weaponValue)
    {
        if (actualShield <= 0)
        {
            actualLife -= weaponValue;
            lifeSlider.value = actualLife;
        }
        else
        {
            actualShield -= weaponValue;
            shieldSlider.value = actualShield;
        }
        if (actualLife <= 0 && !isDead)
        {
            //do what happen when target dies
        }
    }
}
