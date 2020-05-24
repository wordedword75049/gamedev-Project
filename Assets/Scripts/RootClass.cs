using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RootClass : MonoBehaviour
{
    private int ticks = 0;
    private int prev_sec = 0;
    private double food = 0;
	private double foodincome = 0;
	private double power = 0;
	private double powerincome = 0;
	public int farmsCount = 0;
	public int farmsLevel = 1;
	public int powerCount = 0;
	public int powerLevel = 1;
	public int lsectorCount = 0;
	public int lsectorLevel = 1;
	public int peopleAmount = 0;
	public CanvasFields UIcanvas;
	System.Random peoplerand = new System.Random();
	
    void Start()
    { 
        //gold = 0;
    }

    [SerializeField]
    private Settings rootSettings;

    void Update()
    {

        ticks += 1;
        int sec = ticks / 200;
        if (sec > prev_sec)
        {
			int addpeople = peoplerand.Next(0, rootSettings.PeopleCapacity[lsectorLevel-1]*lsectorCount - peopleAmount+1);
			peopleAmount += addpeople;
			UIcanvas.PeopleText.text = ("people: " + peopleAmount);
			powerincome = System.Math.Round(rootSettings.PowerplIncome[powerLevel - 1] * powerCount - farmsCount * rootSettings.FarmPowerUse[farmsLevel-1] - peopleAmount * rootSettings.PeoplePowerUse, 1);
			power += powerincome;
			UIcanvas.PowerText.text = ("power: " + power);
			if (powerincome > 0) {
				UIcanvas.PIncomeText.color = Color.green;
				UIcanvas.PIncomeText.text = "+" + powerincome;
			} else if (powerincome < 0) {
				UIcanvas.PIncomeText.color = Color.red;
				UIcanvas.PIncomeText.text = "-" + System.Math.Abs(powerincome);
			} else {
				UIcanvas.PIncomeText.color = Color.white;
				UIcanvas.PIncomeText.text = "" + System.Math.Abs(powerincome);
			}
			foodincome = System.Math.Round(rootSettings.FarmsIncome[farmsLevel-1] * farmsCount - peopleAmount * rootSettings.PeopleFoodUse, 1);
            food += foodincome ;
            //Debug.Log("I am root and for " + sec + " seconds i got " + food + " food from " + farmsCount + " farms of "+ farmsLevel +" level");
			if (food > 1000) {
				UIcanvas.FoodText.text = ("food: " + System.Math.Round(food/1000, 1) + "K");				
			} else {
				UIcanvas.FoodText.text = ("food: " + food);
			}
			if (foodincome > 0) {
				UIcanvas.IncomeText.color = Color.green;
				UIcanvas.IncomeText.text = "+" + foodincome;
			} else if (foodincome < 0) {
				UIcanvas.IncomeText.color = Color.red;
				UIcanvas.IncomeText.text = "-" + System.Math.Abs(foodincome);
			} else {
				UIcanvas.IncomeText.color = Color.white;
				UIcanvas.IncomeText.text = "" + System.Math.Abs(foodincome);
			}
            prev_sec = sec;
        }
    }
}    
