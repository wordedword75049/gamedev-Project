using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasFields : MonoBehaviour
{
    
    [SerializeField]
    private UnityEngine.UI.Text farmscountText;

    public UnityEngine.UI.Text FarmsCountText => farmscountText;

    [SerializeField]
    private UnityEngine.UI.Text foodText;

    public UnityEngine.UI.Text FoodText => foodText;

	[SerializeField]
    private UnityEngine.UI.Text incomeText;

    public UnityEngine.UI.Text IncomeText => incomeText;

	[SerializeField]
    private UnityEngine.UI.Text powerText;

    public UnityEngine.UI.Text PowerText => powerText;

	[SerializeField]
    private UnityEngine.UI.Text pincomeText;

    public UnityEngine.UI.Text PIncomeText => pincomeText;

	[SerializeField]
    private UnityEngine.UI.Text peopleText;

    public UnityEngine.UI.Text PeopleText => peopleText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
