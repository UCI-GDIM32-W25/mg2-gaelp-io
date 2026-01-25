[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/7qg5CCgx)
# HW2
## Devlog
In my original plan, I intended to have Player, Coin, and UI classes, but as I started coding, I realized I needed a way to manage coin spawning randomly, so I added a CoinSpawner class to handle creating coins at random positions over time. The Player class handles movement and interacts with coins, while the Coin class uses OnTriggerEnter2D to detect when the player collects it, destroy itself, and notify the UIManager to update the score. This change allowed me to keep each class focused on a single responsibility and action at the same time, showing how my initial plan evolved during development while still following the structure I had before.

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - rabbit and item sprites
- [Pixel Penguin 32x32 Asset pack](https://legends-games.itch.io/pixel-penguin-32x32-asset-pack) - penguin sprites
- [Coins 2D](https://artist2d3d.itch.io/2d) - coin sprites