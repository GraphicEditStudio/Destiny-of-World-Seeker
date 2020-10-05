# Unity Style Guide

_An attempt to make Unity projects more consistent._


## Introduction


###  Terminology


**Levels/Scenes** - The word 'scene' generally refers to what the average person calls a 'level' and may be used interchangeably.

**Cases** - There are a few different ways you can name things. Here are some common casing types:


**PascalCase / UpperCamelCase** - Capitalize every word and remove all spaces, e.g. `DesertEagle`, `StyleGuide`, `ASeriesOfWords`.
	
**lowerCamelCase** - The first letter is always lowercase but every following word starts with uppercase, e.g. `desertEagle`, `styleGuide`, `aSeriesOfWords`.

**Snake_case** - Words can arbitrarily start upper or lowercase but words are separated by an underscore, e.g. `desert_Eagle`, `Style_Guide`, `a_Series_of_Words`.

**Variables / Properties** - The words 'variable' and 'property' in most contexts are interchangable. If they are both used together in the same context however:

**Property** -
C# Properties enable a class to expose a public way of getting and setting values, while hiding implementation or verification code. For more about C# properties see [MSDN](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties).

When in the context of a class, often used to imply accessing previously defined data.

**Instance Variable** -
Usually refers to a variable defined in a class. For example, if a script `S_Barrel` had a variable `isExploded`, `isExploded` may be referred to as a property of `S_Barrel`. 
When in the context of a class, often used to imply accessing previously defined data.

**Local Variable** -
 Usually refers to a variable defined as a function argument or a local variable inside a function.
When in the context of a class, often used to convey discussion about its definition and what it will hold.


###  Principles


#### If your Unity project already has a style guide, you should follow it.

If you are working on a project or with a team that has a pre-existing style guide, it should be respected.  Any inconsistency between an existing style guide and this guide should defer to the existing.

Style guides should be living documents however and you should propose style guide changes to an existing style guide as well as this guide if you feel the change benefits all usages.

##### "Arguments over style are pointless. There should be a style guide, and you should follow it." - [_Rebecca Murphey_](https://rmurphey.com)

#### All structure, assets, and code in any Unity Engine project should look like a single person created it, no matter how many people contributed.

Moving from one project to another should not cause a re-learning of style and structure. Conforming to a style guide removes unneeded guesswork and ambiguities.

It also allows for more productive creation and maintenance as one does not need to think about style, simply follow instructions. This style guide is written with best practices in mind, meaning that by following this style guide you will also minimize hard to track issues.

#### Friends do not let friends have bad style.

If you see someone working either against a style guide or no style guide, try to correct them.

When working within a team, it is far easier to help and to ask for help then dealing with inconsistencies. Nobody likes to help untangle someone's code or deal with assets with names they can't understand.

If you are helping someone who's work conforms to a different but consistent and sane style guide, you should be able to adapt to it. If they do not conform to any style guide, please direct them here.

####  A team without a style guide is no team of mine.

When joining a Unity team one of your first questions should be "Do you have a style guide?". If the answer is no, you should direct them here **_AND_** be skeptical about their ability to work as a team.

##  Asset Naming Conventions

Naming conventions should be treated as law. A project that conforms to a naming convention is able to have its assets managed, searched, parsed, and maintained with incredible ease.

Most things are prefixed with prefixes being generally an acronym of the asset type followed by an underscore.

###  Base Asset Name - `Prefix_BaseAssetName_Variant_Suffix` 

All assets should have a _Base Asset Name_. A Base Asset Name represents a logical grouping of related assets. Any asset that is part of this logical group should follow the the standard of  `Prefix_BaseAssetName_Variant_Suffix`.

Keeping the pattern `Prefix_BaseAssetName_Variant_Suffix` in mind and using common sense is generally enough to warrant good asset names. Here are some detailed rules regarding each element.

`Prefix` and `Suffix` are to be determined by the asset type through the following Asset Name Modifier tables.

`BaseAssetName` should be determined by short and easily recognizable name related to the context of this group of assets. For example, if you had a character named Bob, all of Bob's assets would have the `BaseAssetName` of `Bob`.

For unique and specific variations of assets, `Variant` is either a short and easily recognizable name that represents logical grouping of assets that are a subset of an asset's base name. For example, if Bob had multiple skins these skins should still use `Bob` as the `BaseAssetName` but include a recognizable `Variant`. An 'Evil' skin would be referred to as `Bob_Evil` and a 'Retro' skin would be referred to as `Bob_Retro`.

For unique but generic variations of assets, `Variant` is a two digit number starting at `01`. For example, if you have an environment artist generating nondescript rocks, they would be named `Rock_01`, `Rock_02`, `Rock_03`, etc. Except for rare exceptions, you should never require a three digit variant number. If you have more than 100 assets, you should consider organizing them with different base names or using multiple variant names.

Depending on how your asset variants are made, you can chain together variant names. For example, if you are creating flooring assets for an Arch Viz project you should use the base name `Flooring` with chained variants such as `Flooring_Marble_01`, `Flooring_Maple_01`, `Flooring_Tile_Squares_01`.

####  Examples

#####  Bob

| Asset Type              | Asset Name                                                 |
| ----------------------- | ---------------------------------------------------------- |
| Mesh/Object             | O_Bob                                                      |
| Material                | M_Bob                                                      |
| Texture (Diffuse/Albedo)| T_Bob_D                                                    |
| Texture (Normal)        | T_Bob_N                                                    
                                              

#####  Rocks

| Asset Type              | Asset Name                                                 |
| ----------------------- | ---------------------------------------------------------- |
| Mesh (01)               | O_Rock_01                                                  |
| Mesh (02)               | O_Rock_02                                                  |
| Mesh (03)               | O_Rock_03                                                  |
| Material                | M_Rock                                                     |


###  Asset Name Modifiers 

When naming an asset use these tables to determine the prefix and suffix to use with an asset's Base Asset Name.


####  Most Common

| Asset Type              | Prefix     | Suffix     | Notes                            |
| ----------------------- | ---------- | ---------- | -------------------------------- |
| Level / Scene           |            |            | [Should be in the Scenes folder] |
| Prefab                  | PF_        |            |                                  |
| Material                | M_  / ?_   |            |                                  |
| Texture                 | T_         | _?         | [See Textures]    |
| Script                  | S_         |            |                                  |
| ScriptableObject        | SO_        |            |                                  |
| Shader                  | SH_        |            |                                  |
| Mesh / .FBX / .OBJ      | O_         |            |                                  |
| Audio Files / .WAV      | A_         |            |                                  |
| Animation Controller    | AC_        |            |                                  |
| Animation               | AN_        |            |                                  |


###  Textures 

| Asset Type              | Prefix     | Suffix     | Notes                            |
| ----------------------- | ---------- | ---------- | -------------------------------- |
| Texture                 | T_         |            |                                  |
| Texture (Diffuse/Albedo/Base Color)| T_ | _D      |                                  |
| Texture (Normal)        | T_         | _N         |                                  |
| Texture (Roughness)     | T_         | _R         |                                  |
| Texture (Alpha/Opacity) | T_         | _A         |                                  |
| Texture (Ambient Occlusion) | T_     | _O         |                                  |
| Texture (Bump)          | T_         | _B         |                                  |
| Texture (Emissive)      | T_         | _E         |                                  |
| Texture (Mask)          | T_         | _M         |                                  |
| Texture (Specular)      | T_         | _S         |                                  |
| Texture (Packed)        | T_         | _*         | See notes below about [packing]. |
| Texture Cube            | TC_        |            |                                  |
| Media Texture           | MT_        |            |                                  |
| Render Target           | RT_        |            |                                  |
| Cube Render Target      | RTC_       |            |                                  |
| Texture Light Profile   | TLP        |            |                                  |


##  Content Directory Structure 

Equally important as asset names, the directory structure style of a project should be considered law. Asset naming conventions and content directory structure go hand in hand, and a violation of either causes unneeded chaos.

There are multiple ways to lay out the content of a Unity project. In this style, we will be using a structure that relies more on filtering and search abilities of the Project Window for those working with assets to find assets of a specific type instead of another common structure that groups asset types with folders.

If you are using the prefix naming convention above, using folders to contain assets of similar types such as `Meshes`, `Textures`, and `Materials` is a redundant practice as asset types are already both sorted by prefix as well as able to be filtered in the Project Window.


###  Example Project Content Structure
<pre>
|-- Assets
    |-- GenericShooter
        |-- Environment
        |   |-- Industrial
        |   |   |-- Ambient
        |   |   |-- Machinery
        |   |   |-- Pipes
        |   |-- Nature
        |   |   |-- Ambient
        |   |   |-- Foliage
        |   |   |-- Rocks
        |   |   |-- Trees
        |   |-- Office
        |-- Characters
        |   |-- Bob
        |   |-- Common
        |   |   |-- Animations
        |   |   |-- Audio
        |   |-- Jack
        |   |-- Steve
        |   |-- Zoe
        |--Core
        |   |-- Characters
        |   |-- Engine
        |   |-- GameModes
        |   |-- Interactables
        |   |-- Pickups
        |   |-- Weapons
        |-- Effects
        |   |-- Electrical
        |   |-- Fire
        |   |-- Weather
        |-- Scenes
        |   |-- Campaign1
        |   |-- Campaign2
        |-- >MaterialLibrary
        |   |-- Debug
        |   |-- Metal
        |   |-- Paint
        |   |-- Utility
        |   |-- Weathering
        |-- Placeables
        |   |-- Pickups
        |-- Weapons
            |-- Common
            |-- Pistols
            |   |-- DesertEagle
            |   |-- RocketPistol
            |-- Rifles
</pre>

The reasons for this structure are listed in the following sub-sections.



###  Folder Names 

These are common rules for naming any folder in the content structure.


####  PascalCase 

All folder names should be in the form of PascalCase.


####  Never Use Spaces 

Spaces can cause various engineering tools and batch processes to fail. Ideally your project's root also contains no spaces and is located somewhere such as `D:\Project` instead of `C:\Users\My Name\My Documents\Unity Projects`.


####  Never Use Unicode Characters And Other Symbols 

If one of your game characters is named 'Zoë', its folder name should be `Zoe`. Unicode characters can be worse than Spaces for engineering tools and some parts of Unity do not support Unicode characters in paths either.

Related to this, if your project has some unexplained issues and your computer's user name has a Unicode character (i.e. your name is `Zoë`), any project located in your `My Documents` folder will suffer from this issue. Often simply moving your project to something like `D:\Project` will fix these mysterious issues.

Using other characters outside `a-z`, `A-Z`, and `0-9` such as `@`, `-`, `_`, `,`, `*`, and `#` can also lead to unexpected and hard to track issues on other platforms, source control, and weaker engineering tools. 


###  Use A Top Level Folder For Project Specific Assets

All of a project's assets should exist in a folder named after the project. For example, if your project is named 'Generic Shooter', _all_ of it's content should exist in `Assets/GenericShooter`.

There are multiple reasons for this approach.


####  No Global Assets

Often in code style guides it is written that you should not pollute the global namespace and this follows the same principle. When assets are allowed to exist outside of a project folder it often becomes much harder to enforce a strict structure layout as assets not in a folder encourages the bad behavior of not having to organize assets.

Every asset should have a purpose, otherwise it does not belong in a project. If an asset is an experimental test and shouldn't be used by the project it should be put in a `Developer` folder.


#### Reduce Migration Conflicts

When working on multiple projects it is common for a team to copy assets from one project to another if they have made something useful for both. When this occurs, the easiest way to perform the copy is to use **Assets→Export Package** and **Assets→Import Package**. That will copy all the meta data and retain all references to other files.

These dependencies are what can easily get you into trouble. If two project's assets do not have a top level folder and they happen to have similarly named or already previously migrated assets, a new migration can accidentally wipe any changes to the existing assets.


####  Samples, Templates, and Asset Store Content Are Risk-Free

If a team member decides to add sample content, template files, or assets they bought from the Asset Store, it is guaranteed that these new assets will not interfere with the project in any way unless your project's top level folder is not uniquely named.

You can not trust Asset Store content to fully conform to the top level folder rule. Many assets exist that have the majority of their content in a top level folder but also have possibly modified sample content as well as level files polluting the global `Content` folder.

When adhering to the top level folder rule, the worst Asset Store conflict you can have is if two Asset Store assets both have the same Unity sample content. If all your assets are in a project specific folder, including sample content you may have moved into your folder, your project will never break.


####  DLC, Sub-Projects, and Patches Are Easily Maintained

If your project plans to release DLC or has multiple sub-projects associated with it that may either be migrated out or simply not cooked in a build, assets relating to these projects should have their own separate top level content folder. This make cooking DLC separate from main project content far easier. Sub-projects can also be migrated in and out with minimal effort. If you need to change a material of an asset or add some very specific asset override behavior in a patch, you can easily put these changes in a patch folder and work safely without the chance of breaking the core project.


###  Use A Top Level Developers Folder For Local Testing 

A top level folder called 'Developers' should exist and each developer can have a folder in this folder.

During a project's development, it is very common for team members to have a sort of 'sandbox' where they can experiment freely without risking the core project. Because this work may be ongoing, these team members may wish to put their assets on a project's source control server. Not all teams require use of Developer folders, but ones that do use them often run into a common problem with assets submitted to source control.

It is very easy for a team member to accidentally use assets that are not ready for use which will cause issues once those assets are removed. For example, an artist may be iterating on a modular set of static meshes and still working on getting their sizing and grid snapping correct. If a world builder sees these assets in the main project folder, they might use them all over a level not knowing they could be subject to incredible change and/or removal. This causes massive amounts of re-working by everyone on the team to resolve.

If these modular assets were placed in a Developer folder, the world builder should never of had a reason to use them and the whole issue would never happen. 

Once the assets are ready for use, an artist simply has to move the assets into the project specific folder and fix up redirectors. This is essentially 'promoting' the assets from experimental to production.


###  All Scene Files Belong In A Folder Called Scenes 

Scene files are incredibly special and it is common for every project to have its own scene naming system, especially if they work with sub-levels or streaming levels. No matter what system of scene organization is in place for the specific project, all levels should belong in `/Assets/ProjectName/Scenes/`.

Being able to tell someone to open a specific scene without having to explain where it is is a great time saver and general 'quality of life' improvement. It is common for levels to be within sub-folders of `Scenes`, such as `Scenes/Campaign1/` or `Scenes/Arenas/`, but the most important thing here is that they all exist within `Assets/ProjectName/Scenes/`.

This also simplifies the job of cooking for engineers. Wrangling levels for a build process can be extremely frustrating if they have to dig through arbitrary folders for them. If a team's scenes are all in one place, it is much harder to accidentally not cook a scene in a build. It also simplifies lighting build scripts as well as QA processes.


###  Use A `Core` Folder For Critical Prefabs And Other Assets 

Use `/Assets/ProjectName/Core` folder for assets that are absolutely fundamental to a project's workings. For example, base `GameManagers`, `Characters`, `PlayerControllers`, `GameStates`, `PlayerStates`, and related Prefabs and/or Scriptable Objects should live here.

This creates a very clear "don't touch these" message for other team members. Non-engineers should have very little reason to enter the `Core` folder. Following good code structure style, designers should be making their gameplay tweaks in child classes that expose functionality. World builders should be using prefabs in designated folders instead of potentially abusing base classes.

For example if your project requires pickups that can be placed in a level, there should exist a base Pickup class in `Core` that defines base behavior for a pickup. Specific pickups such as a Health or Ammo should exist in a folder such as `/Assets/ProjectName/Placeables/Pickups/`. Game designers can define and tweak pickups in this folder however they please, but they should not touch `Core/Pickup` as they may unintentionally break pickups project-wide.


###  Do Not Create Folders Called `Assets` or `AssetTypes`


####  Creating a folder named `Assets` is redundant.

All assets are assets.


####  Creating a folder named `Meshes`, `Textures`, or `Materials` is redundant.

All asset names are named with their asset type in mind. These folders offer only redundant information and the use of these folders can easily be replaced with the robust and easy to use filtering system the Project Window provides.

> This also extends the full path name of an asset for very little benefit. The `O_` prefix for a mesh is only one characters, whereas `Meshes/` is seven characters.

Not doing this also prevents the inevitability of someone putting a mesh or a texture in a `Materials` folder.


###  Very Large Asset Sets Get Their Own Folder Layout


There are certain asset types that have a huge volume of related files where each asset has a unique purpose. The two most common are Animation and Audio assets. If you find yourself having 15+ of these assets that belong together, they should be together.

For example, animations that are shared across multiple characters should lay in `Characters/Common/Animations` and may have sub-folders such as `Locomotion` or `Cinematic`.

This does not apply to assets like textures and materials. It is common for a `Rocks` folder to have a large amount of textures if there are a large amount of rocks, however these textures are generally only related to a few specific rocks and should be named appropriately. Even if these textures are part of a Material Library.


###  `MaterialLibrary`

If your project makes use of master materials, layered materials, or any form of reusable materials or textures that do not belong to any subset of assets, these assets should be located in `Content/Project/MaterialLibrary`.

This way all 'global' materials have a place to live and are easily located.

This also makes it incredibly easy to enforce a 'use material instances only' policy within a project. If all artists and assets should be using material instances, then the only regular material assets that should exist are within this folder. You can easily verify this by searching for base materials in any folder that isn't the `MaterialLibrary`.

The `MaterialLibrary` doesn't have to consist of purely materials. Shared utility textures, material functions, and other things of this nature should be stored here as well within folders that designate their intended purpose. For example, generic noise textures should be located in `MaterialLibrary/Utility`.

Any testing or debug materials should be within `MaterialLibrary/Debug`. This allows debug materials to be easily stripped from a project before shipping and makes it incredibly apparent if production assets are using them if reference errors are shown.


###  No Empty Folders 

There simply shouldn't be any empty folders. They clutter the Project Window.


##  Scripting


There should never be any unused methods in code (such as Start/Update)
                        

####  Nouns

All non-boolean variable names must be clear, unambiguous, and descriptive nouns.


####  lowerCamelCase

All non-boolean variables should be in the form of lowerCamelCase.

**Examples:**
* score
* kills
* targetPlayer
* crosshairColor


####  Prefixes

Prefixes are discouraged by C# coding standards and we will not be using them here either.


####  General And Independent State Information

All booleans should be named as descriptive adjectives when possible if representing general information. These should be preceded by a verb.

Good examples:

* `isDead`
* `isOnFire`
* `isAlive`
* `isSpeaking`
* `isHavingAnExistentialCrisis`
* `isVisible`
* `hasWeapon` - ["Has" is a verb.](http://grammar.yourdictionary.com/parts-of-speech/verbs/Helping-Verbs.html)
* `wasCharging` - ["Was" is past-tense of "be".](http://grammar.yourdictionary.com/parts-of-speech/verbs/Helping-Verbs.html) Use "was" when referring to 'previous frame' or 'previous state'.
* `canReload` - ["Can" is a verb.](http://grammar.yourdictionary.com/parts-of-speech/verbs/Helping-Verbs.html)

Bad examples:

* `fire` - Is on fire? Will fire? Do fire?
* `onFire` - Can be confused with event dispatcher for firing.
* `dead` - Is dead? Will deaden?
* `visibility` - Is visible? Set visibility? A description of flying conditions?

Try to not use verbs such as `running`. Verbs tend to lead to complex states.


####  Complex States 

Do not to use booleans to represent complex and/or dependent states. This makes state adding and removing complex and no longer easily readable. Use an enumeration instead.

Example: When defining a weapon, do **not** use `reloading` and `equipping` if a weapon can't be both reloading and equipping. Define an enumeration named `WeaponState` and use a variable with this type named `weaponState` instead. This makes it far easier to add new states to weapons.

Example: Do **not** use `running` if you also need `walking` or `sprinting`. This should be defined as an enumeration with clearly defined state names.


####  Redudency with Considered Context 

All variable names must not be redundant with their context as all variable references in script will always have context.

**Example:**

Consider a script called `S_PlayerCharacter`.

**Bad**

* `playerScore`
* `playerKills`
* `myTargetPlayer`
* `myCharacterName`
* `characterSkills`
* `chosenCharacterSkin`

All of these variables are named redundantly. It is implied that the variable is representative of the `S_PlayerCharacter` it belongs to because it is `S_PlayerCharacter` that is defining these variables.

**Good**

* `score`
* `kills`
* `targetPlayer`
* `name`
* `skills`
* `skin`


####  Do _Not_ Include Atomic Type Names 

Atomic or primitive variables are variables that represent data in their simplest form, such as booleans, integers, floats, and enumerations.

Strings and Lists are considered atomic in terms of style when working with C# scripts, however they are technically not atomic.

Atomic variables should not have their type name in their name.

Example: Use `score`, `kills`, and `description` **not** `scoreFloat`, `floatKills`, `descriptionString`.

The only exception to this rule is when a variable represents 'a number of' something to be counted _and_ when using a name without a variable type is not easy to read.

Example: A fence generator needs to generate X number of posts. Store X in `numPosts` or `postsCount` instead of `posts` as `posts` may potentially read as an Array of a variable type named `Post`.


####  Do Include Non-Atomic Type Names 

Non-atomic or complex variables are variables that represent data as a collection of atomic variables. Structs, Classes, Interfaces, and primitives with hidden behavior such as `Text` and `Rigidbody` all qualify under this rule.

While an Array of an atomic variable type is a list of variables, Arrays do not change the 'atomicness' of a variable type.

These variables should include their type name while still considering their context.

If a class owns an instance of a complex variable, i.e. if a `S_PlayerCharacter` owns a `S_Gun`, it should be stored as the variable type as without any name modifications.

Example: Use `hat`, `flag`, and `ability` **not** `myHat`, `myFlag`, and `playerAbility`.

If a class does not own the value a complex variable represents, you should use a noun along with the variable type.

Example: If a `S_Turret` has the ability to target a `S_PlayerCharacter`, it should store its target as `TargetPlayerCharacter` as when in the context of `S_Turret` it should be clear that it is a reference to another complex variable type that it does not own.


####  Arrays / Lists

Arrays follow the same naming rules as above, but should be named as a plural noun.

Example: Use `targets`, `hats`, and `enemyPlayers`, **not** `targetList`, `hatArray`, `enemyPlayerArray`.

Avoid Lists. Only use Arrays and Dictionaries.
Avoid Linq, since it results in boxing elements and impacts Garbage Collection.
Allocate arrays during Awake/Enable phase. Avoid creating arrays during the Game Loop.

#### Inspector Editable Variables 

All variables that are safe to change the value of in order to configure behavior of a prefab should be marked `[SerializeField]` or be public variables.

Conversely, all variables that are not safe to change or should not be exposed to designers should _not_ be marked as public or [SerializeField].

Do not arbitrarily mark variables as `[SerializeField]`.

Variables that need to be serialized but should not be editable in the inspector should be marked '[HideInInspector]'.


####  Tooltips 

All variables visible in the inspector should have a description in a `[Tooltip("Description goes here")]` attribute that explains how changing this value affects the behavior of the script.


####  Slider And Value Ranges 

All variables visible in the inspector should make use of slider and/or value ranges if there is ever a value that a variable should _not_ be set to.

Example: A script that generates fence posts might have an editable variable named `postsCount` and a value of -1 would not make any sense. Use the following code to enforce 0 as a minimum: 

'''void OnValidate() {
     postsCount = Mathf.Max(postsCount, 0);
}'''

A slide can also be used. Use the '[Range(min, max)]' attribute to create a slider with the given min and max.


####  Headers 

If a class has only a small number of variables, headers are not required.

If a class has a moderate/large amount of inspector visible variables (5-10), all variables visibile in the inspector should be grouped under [Header("HeaderNameHere")] attributes, each header describing the group of variables under it. The [Space] and [Space(height)] attributes can also be used for improved readability.


####  Variable Access Level 

In C#, variables have a concept of access level. Public means any code outside the class can access the variable. Protected means only the class and any child classes can access this variable internally. Private means only this class and no child classes can access this variable.

Unless it is known that a variable should only be accessed within the class it is defined and never a child class, do not mark variables as private. Variables should be marked `protected`, reserve private for when you absolutely know you want to restrict child class usage.


###  Functions, Events, and Event Dispatchers 

This section describes how you should author functions, events, and event dispatchers. Everything that applies to functions also applies to events, unless otherwise noted 

The naming of functions and events is critically important. Based on the name alone, certain assumptions can be made about functions.

Events must be subscribed to in the OnEnable phase.

Events must be unsubscribed in the OnDisable phase.

Events should never be published until the Start phase or later.

#### All Functions Should Be Verbs 

All functions, event dispatchers and event handlers perform some form of action, whether its getting info, calculating data, or causing something to explode. 

Therefore, all functions should all start with verbs. They should be worded in the present tense whenever possible. They should also have some context as to what they are doing.

Event handlers and event dispatchers are an exception to this rule.

Good examples:

* `Fire` - Good example if in a Character / Weapon class, as it has context. Bad if in a Barrel / Grass / any ambiguous class.
* `Jump` - Good example if in a Character class, otherwise, needs context.
* `Explode`
* `ReceiveMessage`
* `SortPlayerArray`
* `GetArmOffset`
* `GetCoordinates`
* `UpdateTransforms`
* `EnableBigHeadMode`
* `IsEnemy` - ["Is" is a verb.](http://writingexplained.org/is-is-a-verb)

Bad examples:

* `Dead` - Is Dead? Will deaden?
* `Rock`
* `ProcessData` - Ambiguous, these words mean nothing.
* `PlayerState` - Nouns are ambiguous.
* `Color` - Verb with no context, or ambiguous noun.


####  PascalCase

All functions should be in the form of PascalCase.


####  Info Functions Returning Bool Should Ask Questions 

When writing a function that does not change the state of or modify any object and is purely for getting information, state, or computing a yes/no value, it should ask a question. This should also follow [the verb rule](#bp-funcs-naming-verbs).

This is extremely important as if a question is not asked, it may be assumed that the function performs an action and is returning whether that action succeeded.

Good examples:

* `IsDead`
* `IsOnFire`
* `IsAlive`
* `IsSpeaking`
* `IsHavingAnExistentialCrisis`
* `IsVisible`
* `HasWeapon` - ["Has" is a verb.](http://grammar.yourdictionary.com/parts-of-speech/verbs/Helping-Verbs.html)
* `WasCharging` - ["Was" is past-tense of "be".](http://grammar.yourdictionary.com/parts-of-speech/verbs/Helping-Verbs.html) Use "was" when referring to 'previous frame' or 'previous state'.
* `CanReload` - ["Can" is a verb.](http://grammar.yourdictionary.com/parts-of-speech/verbs/Helping-Verbs.html)

Bad examples:

* `Fire` - Is on fire? Will fire? Do fire?
* `OnFire` - Can be confused with event dispatcher for firing.
* `Dead` - Is dead? Will deaden?
* `Visibility` - Is visible? Set visibility? A description of flying conditions?


####  Event Handlers and Dispatchers Should Start With `On` 

Any function that handles an event or dispatches an event should with `On` and continue to follow the verb rule. The verb may move to the end however if past-tense reads better.

[Collocations](http://dictionary.cambridge.org/us/grammar/british-grammar/about-words-clauses-and-sentences/collocation) of the word `On` are exempt from following the verb rule.

`Handle` is not allowed. For the sake of consistency, On has been chosen to as it is shorter and matches the this style guide is based off of. Other frameworks may prefer to use `Handle` instead of `On`.

Good examples:

* `OnDeath` - Common collocation in games
* `OnPickup`
* `OnReceiveMessage`
* `OnMessageRecieved`
* `OnTargetChanged`
* `OnClick`
* `OnLeave`

Bad examples:

* `OnData`
* `OnTarget`
* `HandleMessage`
* `HandleDeath`


##  Prefabs

This section will focus on Prefab classes and their internals.


###  _Everything_ should be a prefab

Everything in the game should have a prefab, even objects that are only used once in a specific scene. This makes scenes and game objects more distinct and you don't need to edit the scene in order to edit the object.

The only exception to this rule is for scene organization game objects that are used as folders.


## Scenes / Levels

This section will focus on Scene assets and their internals.


###  No Errors Or Warnings

All levels should load with zero errors or warnings. If a level loads with any errors or warnings, they should be fixed immediately to prevent cascading issues.


###  No Player Visible Z Fighting

Levels should not have any [z-fighting](https://en.wikipedia.org/wiki/Z-fighting) in all areas visible to the player. 


###  Use Empty Game Objects as Folders

Organize game objects into folders using empty game objects. Try to maintain a balanced hierarchy, having a hierachy that is too shallow/deep will effect performance.


###  Every Scene is Runnable

A scene should work by playing it from the editor without having to get there through another scene.


## . Meshes / .obj / .fbx

This section will focus on Mesh assets and their internals.



####  All Meshes Should Be Scaled Correctly

This is a subjective check on a per-project basis, however all assets should be scaled correctly to their project. Level designers or blueprint authors should not have to tweak the scale of meshes to get them to confirm in the editor. Scaling meshes in the engine should be treated as a scale override, not a scale correction.


##  Textures 

This section will focus on Texture assets and their internals.


###  Dimensions Are Powers of 2 

All textures, except for UI textures, must have its dimensions in multiples of powers of 2. Textures do not have to be square.

For example, `128x512`, `1024x1024`, `2048x1024`, `1024x2048`, `1x512`.


###  Texture Density Should Be Uniform 

All textures should be of a size appropriate for their standard use case. Appropriate texture density varies from project to project, but all textures within that project should have a consistent density.

For example, if a project's texture density is 8 pixel per 1 unit, a texture that is meant to be applied to a 100x100 unit cube should be 1024x1024, as that is the closest power of 2 that matches the project's texture density. 


###  Textures Should Be No Bigger than 8192 

No texture should have a dimension that exceeds 8192 in size, unless you have a very explicit reason to do so. Often, using a texture this big is simply just a waste of resources.



