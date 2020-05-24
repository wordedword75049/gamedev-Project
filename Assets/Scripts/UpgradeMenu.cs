using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeMenu : MonoBehaviour
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
				if (root.farmsLevel < 3) {
                	root.farmsLevel += 1;
                	ddn.value = 0;
				}
            } else if (ddn.value == 2)
            {
				if (root.powerLevel < 3) {
                	root.powerLevel += 1;
                	ddn.value = 0;
				}
            } else if (ddn.value == 3)
            {
				if (root.lsectorLevel < 3) {
                	root.lsectorLevel += 1;
                	ddn.value = 0;
				}
            }
        });
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
