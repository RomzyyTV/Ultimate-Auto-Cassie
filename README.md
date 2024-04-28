# Ultimate-Auto-Cassie
Handles the cassie system at the start of the game SCP:SL for Roleplay servers and SCP:SL for No Roleplay servers.

# Features
- message from cassie announcing problems on the site
- the lights go off for a limited time that you can choose in your config file

# Default config:
```yaml
  # Cassie is not message translated in french
  cassie: |-
    pitch_1.0 warning pitch_0.2 .g4 .g4 
    pitch_0.9 The site is experiencing many Keter and Euclid level containment breaches, full site unlock down initiated, please evacuation gate B. pitch_0.05 .g7
  # Cassie message translated in frech is not Cassie in english
  message_translated: |-
    Warning, 
    Le site connaît de nombreuses violations de confinement au niveau Keter et Euclide, déverrouillage complet du site initié, veuillez évacuer par la gate B.
  # Is held
  is_held: false
  # Is Noisy
  is_noisy: false
  # Is Subtitles
  is_subtitles: true
  # Time for the lights to go out
  black_out: 4
```
# Installation

**[EXILED](https://github.com/galaxy119/EXILED) must be installed for this to work.**

Place the "Ultimate-Auto-Cassie.dll" file in your Plugins folder.