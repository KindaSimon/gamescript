using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;
public class GameScript : MonoBehaviour
{
    public TMP_Text storyText;
    public TMP_Text choiceText;
    public Sprite[] imageArray;

    enum States
    {
        Car0, Car1, Car2, Car3, Town0, Phone0, Address0, Resident0, Phone1, Sleep0, Outside0, Uncle0, Exit0, Woman0, Aunt0, Motel0, Town1, Friend0, Bar0, Sleep1, Outside1, Family0, Family1, Sleep2, Outside2, Bar1, You0, Liar0, Sorry0, Run0,
        run1, run2,
    };
    States myState;

    // Start is called before the first frame update
    void Awake()
    {
        myState = States.Car0;
    }

    // Update is called once per frame
    void Update()
    {
        if (myState == States.Car0)
        {
            car0();
        }
        else if (myState == States.Car1)
        {
            car1();
        }
        else if (myState == States.Car2)
        {
            car2();
        }
        else if (myState == States.Car3)
        {
            car3();
        }
        else if (myState == States.Town0)
        {
            town0();
        }
        else if (myState == States.Phone0)
        {
            phone0();
        }
        else if (myState == States.Address0)
        {
            address0();
        }
        else if (myState == States.Resident0)
        {
            resident0();
        }
        else if (myState == States.Friend0)
        {
            friend0();
        }
        else if (myState == States.Town1)
        {
            town1();
        }
        else if (myState == States.Motel0)
        {
            motel0();
        }
        else if (myState == States.Sleep0)
        {
            sleep0();
        }
        else if (myState == States.Aunt0)
        {
            aunt0();
        }
    }

    void car0()
    {
        storyText.SetText("'I have no clue why they aren't returning any of my calls' you say, annoyed." +
"'Well I have no clue why you decided to go meet them in the first place Andy, we barely talk to them.'" +
"your sister says, nagging at you through the phone." +
"You're calling her while currently in the middle of a road trip that's expected to last 13 hours, all to meet your " +
"aunt and uncle who you've never met before. In fact, you've only ever seen one photo of them, and its from the early 80's." +
"'I just wanted to give them a chance,' you say back to her, starting to think you shouldn't have even started this trip in" +
" the first place. 'I don't know Andy, this just seems like a waste of a good spring break.' she replies.");

        choiceText.SetText("Press 1 to Hang Up / Press 2 to Turn Around / Press 3 to Call Aunt");

        GameObject.Find("Panel").GetComponent<Image>().sprite = imageArray[0];

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            myState = States.Car1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            myState = States.Car2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            myState = States.Car3;
        }
    }
    void car1()
    {
        storyText.SetText("you hang up on your sister angrily and keep driving down the road. 'waste of a spring break' you mumble, mocking her.");

        choiceText.SetText("Press 1 to try calling your aunt and uncle again while driving / Press 2 to fast forward to arrival");

        GameObject.Find("Panel").GetComponent<Image>().sprite = imageArray[0];

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            myState = States.Town0;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            myState = States.Car2;
        }
    }
    void car2()
    {
        storyText.SetText("you call them, and they still don't pick up. even though you have every reason not to, you still feel this weird inclination to visit them. so nevertheless, you reluctantly continue driving.");

        choiceText.SetText("Press 1 to fast forward to arrival");

        GameObject.Find("Panel").GetComponent<Image>().sprite = imageArray[0];

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            myState = States.Town0;
        }
    }
    void car3()
    {
        storyText.SetText("you hang up and turn your car around, when suddenly your aunt calls you. you immediately pick up, and hear silence for a few seconds" +
            "\"uh hello? Andy DON\'T-\" she says, followed by the call ending immediately. you sit in silence for a moment, confused, as you make a decision.despite what your sister tells you, you decide to turn around, again, and go back on the path to your aunt\'s and uncle\'s house.");

        choiceText.SetText("Press 1 to try calling your aunt and uncle again while driving / Press 2 to fast forward to arrival");

        GameObject.Find("Panel").GetComponent<Image>().sprite = imageArray[0];

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            myState = States.Town0;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            myState = States.Car2;
        }
    }
    void town0()
    {
        storyText.SetText("you arrive at the town at 5:43 PM, what do you do first?");

        choiceText.SetText("Press 1 to check up on a friend you think is in town / Press 2 to go to the address your aunt and uncle gave you / Press 3 to wander the town and look around");

        GameObject.Find("Panel").GetComponent<Image>().sprite = imageArray[0];

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            myState = States.Friend0;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            myState = States.Address0;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            myState = States.Town1;
        }
    }
    void friend0()
    {
        storyText.SetText("you check in on your friends work only to find the place isn't there. even though your phone told you the address, it seems to be wrong. what do you do?");

        choiceText.SetText("Press 1 to check phone / Press 2 to return to options");

        GameObject.Find("Panel").GetComponent<Image>().sprite = imageArray[0];

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            myState = States.Phone0;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            myState = States.Town0;
        }
    }
    void address0()
    {
        storyText.SetText("you drive to the address they gave you, only to find a burnt down apartment building in it's place. " +
            "confused and worried, you call them again, but to no avail. you see an old town resident nearby, what do you do?");

        choiceText.SetText("Press 1 to talk to the town resident to seek information");

        GameObject.Find("Panel").GetComponent<Image>().sprite = imageArray[0];

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            myState = States.Resident0;
        }
    }
    void phone0()
    {
        storyText.SetText("your phone shuts itself off at 30%, luckily though, " +
            "you have the address your aunt and uncle gave you written down, so you plan to charge it when you get there.");

        choiceText.SetText("Press 1 to go back to town options");

        GameObject.Find("Panel").GetComponent<Image>().sprite = imageArray[0];

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            myState = States.Town0;
        }
    }
    void town1()
    {
        storyText.SetText("you start to wander the town, looking around and checking out what the town has to offer. " +
            "you notice as you drive though, a worrying amount of burn marks on each building. ");

        choiceText.SetText("Press 1 to go to the address they gave you / Press 2 to go to a motel");

        GameObject.Find("Panel").GetComponent<Image>().sprite = imageArray[0];

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            myState = States.Address0;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            myState = States.Motel0;
        }
    }
    void motel0()
    {
        storyText.SetText("you check in at a motel worried from everything you've seen today.");

        choiceText.SetText("Press 1 to go to sleep / Press 2 to stay up trying to turn your phone back on");

        GameObject.Find("Panel").GetComponent<Image>().sprite = imageArray[0];

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            myState = States.Sleep0;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            myState = States.Phone1;
        }
    }
    void sleep0()
    {
        storyText.SetText("you go to sleep, with a lot on your mind about every weird and creepy thing that's happened today, only to wake up to a couple in the next room over arguing their ears off.");

        choiceText.SetText("Press 1 to leave the room");

        GameObject.Find("Panel").GetComponent<Image>().sprite = imageArray[0];

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            myState = States.Outside0;
        }
    }
    void resident0()
    {
        storyText.SetText("you see an old man who seems to be a resident of the town. you ask him for answers." +
            "<br>\'uh hi sir? my name\'s Andy uh m - my aunt and uncle - they gave me this address as where they were staying at, uh did the building burn down or something ?\' " +
            "<br>\'huh? oh of course it did, but long ago. back in the 90\'s, there were these fires that were set by two of Illinois most wanted. luckily, they were caught.\'" +
            "<br>\'oh the police were able to get them?\' " +
            "<br>\'not the police.\' he says back to you. " +
            "<br> you stare blankly at him. " +
            "<br>\'I suggest you leave this town while you still can.\' he says. " +
            "<br> he walks away.");

        choiceText.SetText("Press 1 to go to a motel and check out for the night");

        GameObject.Find("Panel").GetComponent<Image>().sprite = imageArray[0];

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            myState = States.Motel0;
        }
        void outside0()
        {
            storyText.SetText("you wake up and exit your motel room as the bright sun practically blinds you and you feel exhausted. a homeless man right outside your door starts begging for money, so you give him some. you hear kids on the playground fighting over a ball, and see a car on the road swerving left and right." +
                "<br> that last thing you see, is an old woman, running up to you with a giant amount of stress in her eyes." +
                "<br>\"Please sir please, have you seen my child???\" she says, tears streaming down her face." +
                "<br>\"uh I don't think I have, I'm sorry ma'am\"" +
                "<br>\"oh god\" she whines, running away from you." +
                "<br>you feel uncomfortable, but also sad that she has to go through this.");

            choiceText.SetText("Press 1 to leave the town / Press 2 to look for the woman");

            GameObject.Find("Panel").GetComponent<Image>().sprite = imageArray[0];

            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                myState = States.Exit0;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                myState = States.Woman0;
            }
        }
        void exit0()
        {
            storyText.SetText("after everything that's happened, you decide coming here was a mistake. " +
                "you get in your car to try and leave town, only to see its out of gas. you filled it up yesterday, so you're extremely confused and frustrated. you go to look for a gas station, only to find that this town has none that are still open. " +
                "your confusion and frustration are even greater now.");

            choiceText.SetText("Press 1 to go to the distillery down the street");

            GameObject.Find("Panel").GetComponent<Image>().sprite = imageArray[0];

            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                myState = States.Bar0;
            }
            
        }
        void aunt0()
        {
            storyText.SetText("\"oh hi Andy\" your aunt says on the other end of the line." +
                "<br> her voice is different." +
                "<br>\"uh where are you guys?? why aren't you-\" " +
                "<br>\"trust that you will be seeing your aunt and uncle soon, Andy.\"");

            choiceText.SetText("Press 1 to go to sleep / Press 2 to vocationem avunculi");

            GameObject.Find("Panel").GetComponent<Image>().sprite = imageArray[0];

            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                myState = States.Sleep0;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                myState = States.Phone1;
            }
        }
        void bar0()
        {
            storyText.SetText("you enter the bar stressed out and tired. by the time you leave it's night, and you're a little less stressed out now.");

            choiceText.SetText("Press 1 to go to sleep");

            GameObject.Find("Panel").GetComponent<Image>().sprite = imageArray[0];

            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                myState = States.Sleep1;
            }
        }
        void sleep1()
        {
            storyText.SetText("you go to sleep, reeking of an amount of booze only a 21 year old college student like yourself could consume. " +
                "again, you wake up to a couple next door arguing.");

            choiceText.SetText("Press 1 to leave the room");

            GameObject.Find("Panel").GetComponent<Image>().sprite = imageArray[0];

            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                myState = States.Outside1;
            }
        }
        void phone1()
        {
            storyText.SetText("your phone still wont turn on, so you decide-" +
                "<br>oh" +
                "<br>it turned on");

            choiceText.SetText("vocatio matertera / vocationem avunculi");

            GameObject.Find("Panel").GetComponent<Image>().sprite = imageArray[0];

            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                myState = States.Aunt0;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                myState = States.Uncle0;
            }
        }
        void uncle0()
        {
            storyText.SetText("\"we are so excited to meet you\" your uncle says from the other end of the phone" +
                "<br>\"where are you guys? i was looking all over-\"" +
                "<br>\"you'll find us soon enough.\" he says back to you.");

            choiceText.SetText("Press 1 to go to sleep / Press 2 to vocatio matertera");

            GameObject.Find("Panel").GetComponent<Image>().sprite = imageArray[0];

            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                myState = States.Sleep0;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                myState = States.Aunt0;
            }
        }
        void woman0()
        {
            storyText.SetText("you look for the woman to see where she went, but to no avail.");

            choiceText.SetText("Press 1 to leave town / Press 2 to go to a distillery");

            GameObject.Find("Panel").GetComponent<Image>().sprite = imageArray[0];

            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                myState = States.Exit0;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                myState = States.Bar0;
            }
        }
        void outside1()
        {
            storyText.SetText("you wake up and exit your motel room as the bright sun practically blinds you and you feel exhausted. a homeless man right outside your door starts begging for money, so you give him some. you hear kids on the playground fighting over a ball, and see a car on the road swerving left and right." +
                "<br>that last thing you see, is an old woman, running up to you with a giant amount of stress in her eyes." +
                "<br>\"Please sir please, have you seen my child???\" she says, tears streaming down her face." +
                "<br>\"oh there you are, I was looking for you yesterday, I still haven't seen your child though.\"" +
                "<br>\"what are you talking about??\" she whines, running away from you." +
                "<br>you feel uncomfortable, and like a giant amount of deja vu is sweeping over you.");

            choiceText.SetText("Press 1 to go back to the bar  / Press 2 to look for your family more");

            GameObject.Find("Panel").GetComponent<Image>().sprite = imageArray[0];

            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                myState = States.Bar1;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                myState = States.Family0;
            }
        }
    }
}
