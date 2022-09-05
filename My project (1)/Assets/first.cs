using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class first : MonoBehaviour

{
    string HeroName = "Flfol";
         float heroHight = 1.90f;
    int heroAge = 35;
    string herosuperPower = "super jump";


    string villainName = "venom";
         float villainHight = 4.9f;
    int villainAge = 44;
    string villainsuperPower = "speed";
    // Start is called before the first frame update
    void Start()
    {
        print("my hero name is " + HeroName + "my hero hight is " + heroHight + "my hero age is" +heroAge+" and his super power is " +herosuperPower);

        print("my villain name is " + villainName + "my villain hight is " + villainHight + "my villain age is" + villainAge + " and his super power is " + villainsuperPower);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
