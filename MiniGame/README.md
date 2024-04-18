```mermaid
classDiagram
    class Character {
        -Weapon[] weapons
        +string Name
        +void Fight()
    }

    class Enemy {
        +Enemy(string name)
    }

    class Player {
        +Player(string name)
    }

    class Weapon {
        -float power
    }

    class Gun {
        -int Ammo
        +void FireGun()
    }

    class Sword {
        -float BladeLength
        +void AttackWithSword()
    }

    Character <|-- Enemy
    Character <|-- Player
    Character "1" o-- "3" Weapon
    Weapon <|-- Gun
    Weapon <|-- Sword
