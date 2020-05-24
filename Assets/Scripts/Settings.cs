using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Settings File", menuName = "Game Settings File", order = 51)]
public class Settings : ScriptableObject
{

	[SerializeField]
    private float peopleFoodUse;

	public float PeopleFoodUse => peopleFoodUse;

	[SerializeField]
    private float peoplePowerUse;

	public float PeoplePowerUse => peoplePowerUse;

	[SerializeField]
    private float[] farmPowerUse;

	public float[] FarmPowerUse => farmPowerUse;

    [SerializeField]
    private int[] peopleCapacity;

	public int[] PeopleCapacity => peopleCapacity;

    [SerializeField]
    private int[] powerplIncome;

	public int[] PowerplIncome => powerplIncome;

    [SerializeField]
    public int[] farmsIncome;
        
    public int[] FarmsIncome => farmsIncome;

}
