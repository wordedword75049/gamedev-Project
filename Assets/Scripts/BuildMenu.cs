using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildMenu : MonoBehaviour
{
    [SerializeField]
    RootClass root;
    [SerializeField] public UnityEngine.UI.Dropdown ddn;
    
    
    // Start is called before the first frame update
    void Start()
    {
        ddn.onValueChanged.AddListener(delegate {
            if (ddn.value == 1)
            {
                root.farmsCount += 1;
                ddn.value = 0;
            } else if (ddn.value == 2)
            {
                root.powerCount += 1;
                ddn.value = 0;
            }
            else if (ddn.value == 3)
            {
                root.lsectorCount += 1;
                ddn.value = 0;
            }
            
        });
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}