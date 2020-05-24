using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    [SerializeField]
    RootClass root;

    [SerializeField] public UnityEngine.UI.Button btn;

    public void OnClick()
    {
        root.farmsCount += 1;
        
    }

    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(OnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
