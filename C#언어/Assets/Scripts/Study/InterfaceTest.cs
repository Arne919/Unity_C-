using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceTest : MonoBehaviour
{

    void GotoLand(IWalk walk)
    {
        walk.Walk();
    }

    void GotoWater(ISwim swim)
    {
        swim.Swim();
    }

    // Start is called before the first frame update
    void Start()
    {
        MyList<int> myList = new MyList<int>();
        myList.value = 1;

        MyList<string> myListS = new MyList<string>();
        myList.value = "¹®ÀÚ³×";

        MyList<GameObject> myListG = new MyList<GameObject>();
        myListG.value = new GameObject();

        myList.ShowValue();
        myListS.ShowValue();
        myListG.ShowValue();

        myList.test(1);
        myListS.test("¾È³ç");
        myListG.test(new GameObject());

        //Fish fish = new Fish();
        //Rabbit rabbit = new Rabbit();
        //UFarufa uFarufa = new UFarufa();

        //GotoLand(rabbit);
        //GotoLand(uFarufa);

        //GotoWater(fish);
        //GotoWater(uFarufa);

        //ISwim s = fish;
        //ISwim s1 = uFarufa;

        //fish.Swim();
        //rabbit.Walk();

        //uFarufa.Walk();
        //uFarufa.Swim();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
