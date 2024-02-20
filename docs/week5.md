# Week 5
Hello again! Today, we'll meet as a group to...
- Review homework
- Randomize starting frame for animation clips
- Introduce the UI system
- Keep track of score
- Set up timers


---

## Review homework
Pull up your projects from homework. Hannah and I will go around and check your progress and answer any relevant questions you might have. 

### Having issues?
_Having trouble with classwork? Need to review?_ Please set up some time to meet with me outside of class. I'm available most of the day on Wednesdays and I love to help.

---

## Unity Demos

### Unity Demos for this week
- Adding a GameManager to keep track of a player's progress (scoring, for example)
- Communicating between GameObjects
- Using coroutines to create timed events
- Adding text-based UI

#### Demo Materials
- Here are a few C# scripts to get us started this evening ([link](https://drive.google.com/file/d/1Z1wiFvey1p2An1kTQVK14sokEfxk83Wn/view?usp=sharing))
- Written notes can be found [here](https://docs.google.com/document/d/1EN-1N-adMyjwTyIo-eD6kpBYPLBdI8f5boTNsjWHmH8/edit?usp=sharing).
- Videos of today's demos are available [here](https://youtube.com/playlist?list=PL42xm44H83rL4NzR4ieKJf5YcZEcqMrZU&si=Adp-_6Mgc7QlNrSg). 


# Homework

## Exercise 3: Keep Moving!
This week you'll continue the small game prototype that you began last week for homework. In addition to giving you some experience working with the animator, prefabs, and audio clips, you'll also...

- Get GameObjects to communicate with one another.
- Keep track of game states and player progression using a GameManager.
- Create timed events using IEnumerator coroutines.
- Display text as an in-game user interface(UI).

### Overview:
For this exercise, you will prototype a simple game in which a player must collect a small number of items before time runs out. This activity will be complicated in a fun way by various moving obstacles in the level.

### For this week (Week 5):
1. Create a GameManager GameObject in your Scene
    - Start with an Empty GameObject and name it GameManager.
    - Create a GameManager script and add it to the GameObject.
    - Write the C# code we covered in class today to keep track of the player's progress and create a countdown timer.

2. Add UI Text to your Scene
    - Import TextMeshPro Essentials
    - Add a Canvas and set its UI Scaling to use Scale with Screen Size. 
    - Add a Text box for the countdown timer, positioning and anchoring it to the top center of the canvas.
    - Import a custom font and use that for your text.

3. Add a reference to your UI in GameManager
    - Make sure to connect the UI up to your code so that it can display the countdown.

4. Create an script for collecting Items
    - Add script to the Player which keeps track of the number of items collected with OnTriggerEnter2D.

5. Finish the GameManager
    - When the timer ends, it needs to check the item counter. 
    - If it's greater or equal, load a win Scene.
    - Otherwise, the game goes to a losing Scene.

6. Add start and ending scenes
    - Each Scene needs instructions and a message for the player
    - _Don't forget to let the player know how to advance to the next Scene!_


__Reminder: Please do not use unlicensed artwork in your classwork (no matter how good that animated sprite dump is that you find online!)__


### This week's technical goals:
- Tagging your GameObjects
- Create a countdown timer with IEnumerator and StartCoroutine
- Set up UI and update the text
- Create a win condition based on counting something


#### Important:
To submit this assignment to Canvas:

__I need the project files.__ Please do not submit builds.

1. Locate the Unity Project folder (you can use Unity Hub to do this).
2. Zip up the entire folder (make sure the Unity project is not open when you do this or the process will fail).
3. **Rename the zip file _yourname_2d_exercise3.zip_**
4. Upload it to your Google Drive, get the shareable link, and then submit that URL to the Canvas assignment.