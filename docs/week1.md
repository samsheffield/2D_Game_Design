# Welcome to Intro to Unity Engine: 2D Game Design
So excited to welcome you all back. In person! Today, we'll meet as a group to...
- Say hello! (Who are you? What are you excited/nervous about this year?)
- Discuss this class. Here's the [syllabus](https://docs.google.com/document/d/1Op47IfWt5YBY5f0xIPnmlZyfWW1yjgQnGT3cNVEoe5Q/edit?usp=sharing).

---

## A little game (and a little game design)

### Five Finger Game 
Players: This is a game for 3 or more players

Goal: The last person with fingers remaining wins

Rules:
- Each person holds 5 fingers extended in front of them.
- Players take turns eliminating each others' fingers by pointing at them (eliminated fingers are folded).
- The last person with visible fingers is the winner.

Variation:
Let's alter the rules, to work on learning each other's names:
- Before starting a round, go around the circle and say names.
- When you point to someone, say their name. If correct, they lose a finger. If wrong, you lose one.

Now let's make another variation:
- What can we add or remove from the base game to change the experience for players?
- What do we expect the outcome to be?
- Let's test our assumptions!



## What is a game?
A very simplistic definition of a game could be: A game is a form of play structured by rules. There are many, many types of games and in this class we are going to focus specifically on __video games__.

[What makes a game a game?](https://docs.google.com/document/d/1OB0BauzLbWrm0RRiVDrzQ8-OPzrp-qee-qv1Xf4kUfc/edit?usp=sharing)

---

## What is Game Design? 
Game design is the collective set of processes used to create the systems and rules of games. As game designers, [what are we designing?](https://docs.google.com/document/d/1suAha_feEg5-jEPNg7BxoWHh8h2x_Gt6HOxqMT1A7b8/edit?usp=sharing)



---

## What is Unity?
Unity is a cross-platform real-time development platform used to create games, apps, and other interactive digital experiences. While it has many broad applications, it is still known primarily as a game engine.

### Unity is a Game Engine
A __game engine__ is a set of tools designed for the development of video games. Game engines include software tools and libraries of code which are intended to make it easier to create video games. 

### Unity License
While Unity is free-of-cost for individuals and small organizations with less than $100K in revenue in the past 12 months, it still requires a license. Please select __Personal License__ when prompted during the installation process.

---

## Installing Unity
You will need:
- At least 7 GB on your computer's hard drive
- A free Unity ID (which you can make at [unity.com](https://unity.com/))
- Unity Hub (which is downloaded by clicking on the Download button at unity.com)

---

## Unity Hub
Unity Hub is a standalone program used to create and manage Unity projects and installations of the Unity Editor.

You can use the Hub to:
- Manage, download, and install modules and versions of the Unity Editor.
- Create and manage your Unity projects.
- Explore templates, sample projects, and learning materials for different skill levels.
- Manage your profile, preferences, and Unity licenses.

### Installing Unity and Visual Studio from Unity Hub
We're going to install the Unity Editor and Visual Studio together this evening in class.
- Make sure to install the 2022 LTS version
- This will also install Visual Studio (or Visual Studio for Mac).
- Windows users will add optional build support for Mac, and Mac users will add optional build support for Windows.

The process of adding and removing new Unity installs can be found in the [official documentation](https://docs.unity3d.com/hub/manual/AddEditor.html).

### Managing projects with Unity Hub 
Today we'll take a look at creating and opening Unity projects with the Unity Hub. Here is the [documentation](https://docs.unity3d.com/hub/manual/Projects.html).

## Tour of the Unity Editor and some basic concepts
Let's take a tour of the Unity Editor and look at it's most important parts:
- Scene view
- Game view
- Hierarchy pane
- Project pane
- Inspector pane

## Scenes
Video games built with Unity are organized using __Scenes__. A Scene can be thought of as a video game level, containing all of the things (visible or not) that make up that level.

## GameObjects
All things that exist in a Scene are referred to as __GameObjects__. These might be playable characters, or text displaying a score on the screen, or something which plays music, or even something which spawns other GameObjects.

GameObjects are... 
- Organized in a Scene using the __Hierarchy__ pane.
- Manipulated and positioned in a Scene using the __Scene View__.
- Adjusted and given behaviors with Components in the __Inspector__ pane.

### Components
GameObjects are defined by their __Components__. These are behaviors and attributes that define what a GameObject does in a Scene. There are many built-in components that handle commonly needed tasks, but we will also create our own Components using a programming language called C#. A GameObject's Components can be managed in the __Inspector__ pane.

### Camera
Everything that we see in our Scene is being captured by a camera. 

There are two types of cameras in Unity:
- Perspective: This camera renders distance in a realistic way. Used primarily in 3D games
- Orthographic: This camera flattens everything, regardless of distance. This is primarily used in 2D games.

A camera's properties are adjusted in the Inspector.


# Homework

## Join the MICA Game Lab Discord
- Join the class Discord server ([link](https://discord.gg/5bjj9Pfz)). 
- Click the star emote in the #welcome-and-rules channel to see all channels.
- Set your server nickname to what you want to be called in class.
- Say hi and post a picture in the #intro-to-unity-2d channel

## Get ready for the semester
- [ ] Do you have room on your laptop's hard drive?
- [ ] Do you have an external hard drive?
- [ ] Do you have storage space on your MICA Google Drive?
- [ ] Do you have a 3 button mouse?
- [ ] Optional: Do you want to purchase the textbook?

## Install Unity Hub on your computer(s)
If you have another computer at home that you want to use for classwork, go ahead and install it there this weekend. Or, if you didn't have your laptop this evening, be sure to install Unity before next class.
- Remember to install all of the software through Unity Hub.
- Be sure to choose Unity 2022 LTS.
- Be sure to install Visual Studio (or Visual Studio for Mac).
- If you are on Windows: add build support for Mac. If you are on Mac: add build support for Windows.

## Unity: First Steps
To deepen our hands-on investigation of the Editor this evening, please review the following sections of the Unity manual:
- [Unity's interface](https://docs.unity3d.com/Manual/UsingTheEditor.html)
- [The Toolbar](https://docs.unity3d.com/Manual/Toolbar.html)
- [Scene View: Default Scene view overlay reference, Position GameObjects, Scene view navigation, Pick and select GameObjects](https://docs.unity3d.com/Manual/default-overlays-reference.html)
- [The Hierarchy window](https://docs.unity3d.com/Manual/Hierarchy.html)
- [The Inspector window: Working in the Inspector](https://docs.unity3d.com/Manual/UsingTheInspector.html)

And this, in preparation to bring in our own images:
- [Importing Assets](https://docs.unity3d.com/Manual/ImportingAssets.html)
- [Set up sprites](https://docs.unity3d.com/Manual/sprites-setup.html)
- For your reference: [](https://docs.unity3d.com/Manual/texture-type-sprite.html)

## Optional: Sign up for the Global Game Jam!
Global Game Jam (GGJ) is coming up soon (Jan 26-28th). This is a great opportunity to warm up, finish a small game for your portfolio, work with new people/work with old friends/work by yourself, and have fun! **Don't worry if you've never made a game before, you have so many skills to contribute to a team.**

FYI: The GGJ consistently pops up in conversations with visiting game developers as something they view _very positively_ from prospective employees. It demonstrates your engagement with game development outside of school assignments, your ability to meet deadlines and work within constraints, and (possibly) your ability to work with others. 


Sign up [here](https://globalgamejam.org/jam-sites/2024/mica-game-design).