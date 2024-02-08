# Week 4
Hello again! Today, we'll meet as a group to...
- Make a playable build of your homework games
- Introduce the Animator (animating properties and basic sprite-based animation workflow)
- Discuss (simplify?) our player input using Input.GetAxis() and Input.GetAxisRaw()
- Create prefabs to reuse our GameObjects
- Import sound clips and trigger their playback using AudioSource.PlayClipAtPoint()


---

## Review homework
Pull up your projects from homework. Hannah and I will go around and check your progress and answer any relevant questions you might have. 

---

## Unity Demos

### Unity Demos for this week
- Creating a desktop build
- Working with the Input Manager
- Sprite-based Animation
- Animating GameObject properties (example: to create movement!)
- Working with prefabs
- Playing sound effects

#### Demo Materials
- [Here are some assets](https://drive.google.com/file/d/1onxp0kVKR4rcNcvdc4ore9a51cq3_sCK/view?usp=sharing) to use for today's demo. These come from [here](https://kenney.nl/assets/pixel-platformer) and [here](https://sfxr.me/).
- Today's class notes are [here](https://docs.google.com/document/d/1BNluap4vDKJcnzkxuHk_-zzu1P5IxhdzW4bZmiXsk7w/edit?usp=sharing). 

- Videos of today's demos are available [here](https://youtube.com/playlist?list=PL42xm44H83rL4NzR4ieKJf5YcZEcqMrZU&si=Adp-_6Mgc7QlNrSg). 

# Homework

## Exercise 3: Keep Moving!
This week you'll begin a small game prototype that you'll work on over the next two weeks for homework. In addition to continue developing game programming skills, this exercise is intended to give you some experience working with the animator, prefabs, and audio clips.

### Overview:
For this exercise, you will prototype a simple game in which a player must collect a small number of items before time runs out. This activity will be complicated in a fun way by various moving obstacles in the level.

### For this week (Week 4):
1. Create a new Project file
    - Name the project Second_Game.
    - __Do not work on the Week4Demo project we started in class__. Use it as a reference.


1. Create Prefabs of two different GameObjects.
    - One is an obstacle/source of conflict, the other is a collectible item.
    - Each has a looping property (movement, scaling, or rotation) controlled by animation.
    - Each has looping sprite-based animation.
    - Both are contained in an empty GameObject so that it can be repositioned in the Scene.
    - Each are set up with colliders and scripts so that they play a sound and are either destroyed or destroy the player using OnTriggerEnter2D.

2. Add a Player GameObject
    - Use either Input. GetAxis() or Input.GetAxisRaw() for controlling input
    - Optional: add an idle animation for the player.

3. Come up with a theme for your game
    - Who is the player?
    - What is their goal?
    - Where are they?

4. Create on Player Experience Goal for you players
    - What do you want your players to experience when playing your game?
    - Write it down somewhere.


__Reminder: Please do not use unlicensed artwork in your classwork (no matter how good that animated sprite dump is that you find online!)__


### This week's technical goals:
- Use folders to organize your assets (Scripts, Prefabs, Sprites, and Scenes).
- Name your assets the Project pane and GameObjects in Scene using PascalCase.
- Use on of the GetAxis methods to get player input.
- Create a triggered collision between the player and two other types of gameobjects.
- Import a sound and play it using AudioSource.PlayClipAtPoint()

### You will turn this in on February 20th:
Do not submit this assignment to Canvas until February 20th. Next week you will continue to develop the assignment for homework.

_Please bring your progress next week._
